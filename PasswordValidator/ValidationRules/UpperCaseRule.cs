namespace PasswordValidator.ValidationRules
{
    /// <inheritdoc/>
    public class UpperCaseRule : IValidationRule
    {
        /// <inheritdoc/>
        public bool Verify(string password)
        {
            return password.Any(x => char.IsUpper(x));
        }
    }
}
