using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordValidator.ValidationRules
{
    /// <inheritdoc/>
    public class NumericalRule : IValidationRule
    {
        /// <inheritdoc/>
        public bool Verify(string password)
        {
            return password.Any(x => char.IsDigit(x));
        }
    }
}
