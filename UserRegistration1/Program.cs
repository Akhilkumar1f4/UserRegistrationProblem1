class Program
{
    static void Main(string[] args)
    {
        // Example usage for UC 1: Valid First Name
        FirstNameValidator firstNameValidator = new FirstNameValidator();
        try
        {
            string firstName = "John";
            firstNameValidator.ValidateFirstName(firstName);
            Console.WriteLine("First name is valid.");
        }
        catch (InvalidFirstNameException ex)
        {
            Console.WriteLine(ex.Message);
        }

        // Example usage for UC 2: Valid Last Name
        LastNameValidator lastNameValidator = new LastNameValidator();
        try
        {
            string lastName = "Doe";
            lastNameValidator.ValidateLastName(lastName);
            Console.WriteLine("Last name is valid.");
        }
        catch (InvalidLastNameException ex)
        {
            Console.WriteLine(ex.Message);
        }

        // Example usage for UC 3: Valid Email
        EmailValidator emailValidator = new EmailValidator();
        try
        {
            string email = "abc.xyz@bl.co.in";
            emailValidator.ValidateEmail(email);
            Console.WriteLine("Email is valid.");
        }
        catch (InvalidEmailException ex)
        {
            Console.WriteLine(ex.Message);
        }

        // Example usage for UC 4: Valid Mobile Format
        MobileFormatValidator mobileFormatValidator = new MobileFormatValidator();
        try
        {
            string mobile = "91 9919819801";
            mobileFormatValidator.ValidateMobileFormat(mobile);
            Console.WriteLine("Mobile format is valid.");
        }
        catch (InvalidMobileFormatException ex)
        {
            Console.WriteLine(ex.Message);
        }

        // Example usage for UC 5: Password Rule 1 (Minimum 8 Characters)
        PasswordLengthValidator passwordLengthValidator = new PasswordLengthValidator();
        try
        {
            string password = "passw0rd";
            passwordLengthValidator.ValidatePasswordLength(password);
            Console.WriteLine("Password length is valid.");
        }
        catch (InvalidPasswordLengthException ex)
        {
            Console.WriteLine(ex.Message);
        }

        // Example usage for UC 6: Password Rule 2 (At Least 1 Upper Case)
        PasswordUpperCaseValidator passwordUpperCaseValidator = new PasswordUpperCaseValidator();
        try
        {
            string password = "Password";
            passwordUpperCaseValidator.ValidatePasswordUpperCase(password);
            Console.WriteLine("Password has at least one uppercase letter.");
        }
        catch (InvalidPasswordUpperCaseException ex)
        {
            Console.WriteLine(ex.Message);
        }

        // Example usage for UC 7: Password Rule 3 (At Least 1 Numeric Number)
        PasswordNumericValidator passwordNumericValidator = new PasswordNumericValidator();
        try
        {
            string password = "passw0rd";
            passwordNumericValidator.ValidatePasswordNumeric(password);
            Console.WriteLine("Password has at least one numeric digit.");
        }
        catch (InvalidPasswordNumericException ex)
        {
            Console.WriteLine(ex.Message);
        }

        // Example usage for UC 8: Password Rule 4 (Exactly 1 Special Character)
        PasswordSpecialCharValidator passwordSpecialCharValidator = new PasswordSpecialCharValidator();
        try
        {
            string password = "Password!";
            passwordSpecialCharValidator.ValidatePasswordSpecialChar(password);
            Console.WriteLine("Password has exactly one special character.");
        }
        catch (InvalidPasswordSpecialCharException ex)
        {
            Console.WriteLine(ex.Message);
        }

        // Example usage for UC 9: Clear All Email Samples Separately
        EmailSampleClearer emailSampleClearer = new EmailSampleClearer();
        try
        {
            List<string> emailSamples = new List<string> { "sample1@example.com", "sample2@example.com" };
            emailSampleClearer.ClearAllEmailSamples(emailSamples);
            Console.WriteLine("Email samples cleared.");
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        // Pause console
        Console.ReadLine();
    }
}
