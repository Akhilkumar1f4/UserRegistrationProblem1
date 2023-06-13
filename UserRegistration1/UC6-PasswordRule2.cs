using System.Runtime.Serialization;
using System.Text.RegularExpressions;

public class PasswordUpperCaseValidator
{
    public void ValidatePasswordUpperCase(string password)
    {
        if (string.IsNullOrEmpty(password) || !Regex.IsMatch(password, "^(?=.*[A-Z]).*$"))
        {
            throw new InvalidPasswordUpperCaseException("Invalid password. Password should have at least one uppercase letter.");
        }
    }
}

[Serializable]
internal class InvalidPasswordUpperCaseException : Exception
{
    public InvalidPasswordUpperCaseException()
    {
    }

    public InvalidPasswordUpperCaseException(string? message) : base(message)
    {
    }

    public InvalidPasswordUpperCaseException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected InvalidPasswordUpperCaseException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}