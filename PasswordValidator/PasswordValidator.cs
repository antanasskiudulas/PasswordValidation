using PasswordValidator.ValidationRules;

namespace PasswordValidator
{
	public class PasswordValidator : IPasswordValidator
	{
		private readonly IDatabase? _database;
		private readonly IList<IValidationRule> _rules = new List<IValidationRule>();
		
		public PasswordValidator()
		{
		}

		public PasswordValidator(IDatabase database, IList<IValidationRule> rules)
		{
			_database = database;
            _rules = rules;
		}

		public bool Validate(string password)
        {
            if (_database is null)
            {
                throw new InvalidOperationException($"Database not configured. Please use {typeof(PasswordValidator)} instance with database constructor");
            }

            string storedPassword = _database.GetExistingPassword();

            if (string.Equals(storedPassword, password, StringComparison.InvariantCulture)) 
            {
                return false;
            }

            foreach (IValidationRule rule in _rules)
            {
                bool isValid = rule.Verify(password);

                if (!isValid)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
