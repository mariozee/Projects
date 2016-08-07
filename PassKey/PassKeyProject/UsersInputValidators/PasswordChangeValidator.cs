using PassKey.Data;
using PassKey.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassKey.UsersInputValidators
{
    using SecurityUtilities;

    public class PasswordChangeValidator
    {
        private LoggedUser user;

        public PasswordChangeValidator(LoggedUser user)
        {
            this.user = user;
        }

        public void Validate(string oldPassword, string newPassword, string confirmedNewPassword)
        {
            string inputOldPasswordHash = HashUtilities.HashPassword(oldPassword);
            string originalPasswordHash = RegistryData.GetUserPassword(this.user.Username);

            if (inputOldPasswordHash != originalPasswordHash)
            {
                throw new InvalidPasswordException(GlobalMessages.IncorectPassword);
            }

            if (newPassword != confirmedNewPassword)
            {
                throw new InvalidPasswordException(GlobalMessages.PasswordsMismatch);
            }

            if (string.IsNullOrWhiteSpace(newPassword) ||
                newPassword.Length < Constants.MinPasswordLenght)
            {
                throw new InvalidPasswordException(string.Format(GlobalMessages.InvalidPasswordLenght
                    , Constants.MinPasswordLenght
                    , Constants.MaxPasswordLenght));
            }
        }
    }
}
