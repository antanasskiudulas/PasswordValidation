Password Validator Coding Test
------------------------------

This is a C# .NET 6 console application that can read in a string value input by the user.
This string value will be a password (in clear text) that will be passed to a PasswordValidator class for validation based on certain criteria.
The PasswordValidator class will validate according to the criteria and should return a bool as to whether the password is valid.

Your Task
---------
The Console application has been written for you.
However, the PasswordValidator's Validate method currently throws a NotImplementedException - your task is to implement the method and its unit tests.
This exercise should be performed using a TDD (test-driven development/test-first) approach; so we hope to see unit tests that cover each of the password validation criteria.

Project Structure
-----------------
We have already created the skeleton C# projects and added the setup code for you.
There is one project for the implementation classes (PasswordValidator) and one for the unit test classes (PasswordValidator.Tests).
Two unit testing framework packages are already installed for you so you can code according to your preference:
	-MSTest
	-NUnit
You'll notice that the code syntax for MSTest is currently active while the equivalent syntax for NUnit is commented out next to it.
Just swap these comments around if you'd prefer to use NUnit.
The mocking library 'Moq' is also installed.

Coding
------
You can write your code in either Visual Studio Code or Visual Studio Community/Professional editions.

Visual Studio Code
------------------
We recommend installing some useful extensions:
	-C# by Microsoft
	-.NET Core Test Explorer by Jun Han

1. Open the root folder 'PasswordValidator' in Visual Studio Code.
2. Build the PasswordValidator cs project by selecting the menu option 'Terminal/Run Task.../build'.
3. Build the PasswordValidator.Tests cs project by selecting the menu option 'Terminal/Run Task.../Build Tests'.
4. Run the unit tests by selecting the menu option 'Terminal/Run Task.../Run Tests'.
	Alternatively use the .NET Core Test Explorer extension.
5. Run and debug the console application by:
	-Click the 'Run and Debug' side panel button.
	-Under the 'Run and Debug' dropdown menu ensure that '.NET Core Launch (console)' is selected.
	-Click the 'Start Debugging' button (green triangle).
	-A terminal window will be launched with a tab for build output and a tab for the console application.

Visual Studio Community/Professional
------------------------------------
1. Open the sln file 'PasswordValidator.sln'.
2. Build both the PasswordValidator and PasswordValidator.Tests projects by selecting the 'Build/Build Solution' menu option.
	Alternatively press F6.
3. Run the unit tests by selecting the 'View/Test Explorer' menu option and clicking the 'Run' button.
3. Run the console application by selecting the 'Debug/Start Debugging' menu option.
	Alternatively press F5.

Password Validation Criteria
----------------------------
A valid password should be:
-Between 8 and 20 characters in length
-Should contain at least one lower case character
-Should contain at least one upper case character
-Should contain at least one numerical value
-Should contain at least one of these special characters: !£$%^&*

Bonus Exercise
--------------
Once you have completed the above task an optional further exercise is to write a unit test that checks a database and
compares the newly input password to the previous password. If the previous password matches the newly input password 
then the newly input password is invalid, otherwise it is valid.

*PLEASE NOTE*
The purpose of this particular exercise is to utilise a mocking framework within your unit test in order to perform
this check against a mocked database. For the purposes of the exercise the mocking framework 'Moq' has been installed
as well as a dependency interface (IDatabase) where a method called GetExistingPassword has been defined. An instance
of this interface type is passed to the PasswordValidator class via dependency injection in the second constructor.

You are NOT expected to create an implementation class or code any database logic/connectivity for the IDatabase in this
exercise, but simply to utilise the IDatabasePassword's GetExistingPassword method call with the Moq framework in order
to mock return an existing password value for your logic and unit test.
