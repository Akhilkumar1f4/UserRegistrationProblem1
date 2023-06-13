using System.Runtime.Serialization;
using System.Text.RegularExpressions;

public class PasswordNumericValidator
{
    public void ValidatePasswordNumeric(string password)
    {
        if (string.IsNullOrEmpty(password) || !Regex.IsMatch(password, "^(?=.*\\d).*$"))
        {
            throw new InvalidPasswordNumericException("Invalid password. Password should have at least one numeric digit.");
        }
    }
}

[Serializable]
internal class InvalidPasswordNumericException : Exception
{
    public InvalidPasswordNumericException()
    {
    }

    public InvalidPasswordNumericException(string? message) : base(message)
    {
    }

    public InvalidPasswordNumericException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected InvalidPasswordNumericException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}