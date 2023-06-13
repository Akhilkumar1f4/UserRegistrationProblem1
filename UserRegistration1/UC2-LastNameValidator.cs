using System.Runtime.Serialization;
using System.Text.RegularExpressions;

public class LastNameValidator
{
    public void ValidateLastName(string lastName)
    {
        if (string.IsNullOrEmpty(lastName) || !Regex.IsMatch(lastName, "^[A-Z][a-zA-Z]{2,}$"))
        {
            throw new InvalidLastNameException("Invalid last name. Last name should start with a capital letter and have a minimum of 3 characters.");
        }
    }
}

[Serializable]
internal class InvalidLastNameException : Exception
{
    public InvalidLastNameException()
    {
    }

    public InvalidLastNameException(string? message) : base(message)
    {
    }

    public InvalidLastNameException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected InvalidLastNameException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}