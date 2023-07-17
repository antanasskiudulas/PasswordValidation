namespace PasswordValidator.ValidationRules
{
    /// <inheritdoc/>
    public class SpecialCharRule : IValidationRule
    {
        private readonly char[] ALLOWED_SPECIAL_CHARS = {'!', '£', '$', '%', '^', '&', '*'};

        /// <inheritdoc/>
        public bool Verify(string password)
        {
            return password.Intersect(ALLOWED_SPECIAL_CHARS).Any();
        }
    }
}
