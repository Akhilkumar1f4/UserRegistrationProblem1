using System.Runtime.Serialization;

public class PasswordLengthValidator
{
    public void ValidatePasswordLength(string password)
    {
        if (string.IsNullOrEmpty(password) || password.Length < 8)
        {
            throw new InvalidPasswordLengthException("Invalid password length. Password should have a minimum of 8 characters.");
        }
    }
}

[Serializable]
internal class InvalidPasswordLengthException : Exception
{
    public InvalidPasswordLengthException()
    {
    }

    public InvalidPasswordLengthException(string? message) : base(message)
    {
    }

    public InvalidPasswordLengthException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected InvalidPasswordLengthException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}