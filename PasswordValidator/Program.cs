using Autofac;

namespace PasswordValidator
{
    internal class Program
	{
		static void Main(string[] args)
		{
			ContainerBuilder builder = new();
            builder.RegisterModule<PasswordValidatorModule>();
			IContainer container = builder.Build();

			using (ILifetimeScope scope = container.BeginLifetimeScope())
			{
                IPasswordValidator passwordValidator = scope.Resolve<IPasswordValidator>();

                Console.WriteLine("Please input your password string to be verified and press enter:");
                string? password = Console.ReadLine();

                bool isPasswordValid = false;

                try
                {
                    isPasswordValid= passwordValidator.Validate(password ?? string.Empty);
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine($"{e.Message}");
                    return;
                }

                if (isPasswordValid)
                {
                    Console.WriteLine($"The input password {password} is valid.");
                }
                else
                {
                    Console.WriteLine($"The input password {password} is invalid.");
                }
            }
		}
	}
}