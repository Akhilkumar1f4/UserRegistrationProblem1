using System.Runtime.Serialization;
using System.Text.RegularExpressions;

public class MobileFormatValidator
{
    public void ValidateMobileFormat(string mobile)
    {
        if (string.IsNullOrEmpty(mobile) || !Regex.IsMatch(mobile, "^\\d{2}\\s\\d{10}$"))
        {
            throw new InvalidMobileFormatException("Invalid mobile format.");
        }
    }
}

[Serializable]
internal class InvalidMobileFormatException : Exception
{
    public InvalidMobileFormatException()
    {
    }

    public InvalidMobileFormatException(string? message) : base(message)
    {
    }

    public InvalidMobileFormatException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected InvalidMobileFormatException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}