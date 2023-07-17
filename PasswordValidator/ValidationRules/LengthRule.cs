namespace PasswordValidator.ValidationRules
{
    /// <inheritdoc/>
    public class LengthRule : IValidationRule
    {
        private readonly int _minLength;
        private readonly int _maxLength;

        public LengthRule(int minLength = 8, int maxLength = 20)
        {
            _minLength = minLength;
            _maxLength = maxLength;
        }

        /// <inheritdoc/>
        public bool Verify(string password)
        {
            return password.Length >= _minLength && password.Length <= _maxLength;
        }
    }
}
