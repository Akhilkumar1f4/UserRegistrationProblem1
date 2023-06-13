using System.Runtime.Serialization;
using System.Text.RegularExpressions;

public class PasswordSpecialCharValidator
{
    public void ValidatePasswordSpecialChar(string password)
    {
        if (string.IsNullOrEmpty(password) || !Regex.IsMatch(password, "^(?=.*[@#$%^&+=]).*$"))
        {
            throw new InvalidPasswordSpecialCharException("Invalid password. Password should have exactly one special character.");
        }
    }
}

[Serializable]
internal class InvalidPasswordSpecialCharException : Exception
{
    public InvalidPasswordSpecialCharException()
    {
    }

    public InvalidPasswordSpecialCharException(string? message) : base(message)
    {
    }

    public InvalidPasswordSpecialCharException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected InvalidPasswordSpecialCharException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}