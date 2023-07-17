namespace PasswordValidator.ValidationRules
{
    /// <summary>
    /// Interface for types of validation rules we wish to apply for passwords
    /// </summary>
    public interface IValidationRule
    {
        /// <summary>
        /// Verifies that the password adheres to a given rule
        /// </summary>
        /// <param name="password">Password for which the rule will be applied</param>
        public bool Verify(string password);
    }
}