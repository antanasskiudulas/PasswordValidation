using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PasswordValidator.ValidationRules;

namespace PasswordValidator.Tests
{
	[TestClass]
	public class PasswordValidatorTests
	{
		private List<IValidationRule> _rules = new() 
		{ 
			new LengthRule(),
			new LowerCaseRule(),
			new UpperCaseRule(),
			new NumericalRule(),
			new SpecialCharRule(),
		};

		private IPasswordValidator _passwordValidator;
		private Mock<IDatabase> _mockDatabase;
		
		[TestInitialize]
		public void Setup()
		{
			_mockDatabase = new Mock<IDatabase>();
			_passwordValidator = new PasswordValidator(_mockDatabase.Object, _rules);
		}

		[DataRow("!Passw1", false)]//7 chars, length rule
        [DataRow("!PasswordPasswordPassword1", false)]//26 chars, length rule
        [DataRow("!password1", false)]//all lower, upper case rule
        [DataRow("!PASSWORD1", false)]//all upper, lower case rule
		[DataRow("Password1", false)]//special character rule
        [DataRow("!Password1", true)]//valid password
        [DataRow("!Qwerty123", false)]//same password as currently stored one in DB
        [DataTestMethod]
		public void Validate_ReturnsExpectedValidationResult(string password, bool expectedResult)
		{
			_mockDatabase.Setup(x => x.GetExistingPassword()).Returns("!Qwerty123");

			bool result = _passwordValidator.Validate(password);

			Assert.AreEqual(expectedResult, result);
		}
	}
}