using System.Runtime.Serialization;
using System.Text.RegularExpressions;

public class EmailValidator
{
    public void ValidateEmail(string email)
    {
        if (string.IsNullOrEmpty(email) || !Regex.IsMatch(email, "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$"))
        {
            throw new InvalidEmailException("Invalid email format.");
        }
    }
}

[Serializable]
internal class InvalidEmailException : Exception
{
    public InvalidEmailException()
    {
    }

    public InvalidEmailException(string? message) : base(message)
    {
    }

    public InvalidEmailException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected InvalidEmailException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}