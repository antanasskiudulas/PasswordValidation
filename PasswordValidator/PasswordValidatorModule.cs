using Autofac;
using PasswordValidator.ValidationRules;

namespace PasswordValidator
{
    public class PasswordValidatorModule : Module
    {

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PasswordValidator>()
                .As<IPasswordValidator>()
                .SingleInstance();

            builder.RegisterType<LengthRule>()
                .As<IValidationRule>()
                .SingleInstance();

            builder.RegisterType<LowerCaseRule>()
                .As<IValidationRule>()
                .SingleInstance();

            builder.RegisterType<NumericalRule>()
                .As<IValidationRule>()
                .SingleInstance();

            builder.RegisterType<SpecialCharRule>()
                .As<IValidationRule>()
                .SingleInstance();

            builder.RegisterType<UpperCaseRule>()
                .As<IValidationRule>()
                .SingleInstance();
        }
    }
}
