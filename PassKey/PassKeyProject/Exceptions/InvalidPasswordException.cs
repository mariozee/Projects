namespace PassKey.Exceptions
{
    public class InvalidPasswordException : PassKeyException
    {
        public InvalidPasswordException(string message)
            : base(message)
        {
        }
    }
}