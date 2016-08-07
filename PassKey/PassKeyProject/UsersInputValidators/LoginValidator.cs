namespace PassKey.UsersInputValidators
{
    using Data;
    using Exceptions;
    using System.Linq;
    using SecurityUtilities;

    public class LoginValidator
    {
        public void ValidateInput(string username, string password)
        {
            if (!RegistryData.GetUsernames().Contains(username))
            {
                throw new InvalidUsernameException(GlobalMessages.NonExistingUser);
            }

            string hashedPassword = RegistryData.GetUserPassword(username);
            string currentPasswordHash = HashUtilities.HashPassword(password);
            if (hashedPassword != currentPasswordHash)
            {
                throw new InvalidPasswordException(GlobalMessages.IncorectPassword);
            }
        }
    }
}