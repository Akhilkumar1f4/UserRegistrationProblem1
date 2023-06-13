using System.Text.RegularExpressions;
public class InvalidFirstNameException : Exception
{
    public InvalidFirstNameException(string message) : base(message)
    {
    }
}

public class FirstNameValidator
{
    public void ValidateFirstName(string firstName)
    {
        if (string.IsNullOrEmpty(firstName) || !Regex.IsMatch(firstName, "^[A-Z][a-zA-Z]{2,}$"))
        {
            throw new InvalidFirstNameException("Invalid first name. First name should start with a capital letter and have a minimum of 3 characters.");
        }
    }
}
