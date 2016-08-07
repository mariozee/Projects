namespace PassKey.UsersActionHandlers
{
    using Data;
    using SecurityUtilities;

    public class PasswordChangeHandler
    {
        private LoggedUser user;

        public PasswordChangeHandler(LoggedUser user)
        {
            this.user = user;
        }

        public void ChangePassword(string newPassword)
        {
            string encryptedData = RegistryData.GetUserData(this.user.Username);
            string decryptedData = CryptographicUtilities.Decrypt(encryptedData, this.user.Key);

            byte[] newKey = HashUtilities.HashKey(newPassword);
            encryptedData = CryptographicUtilities.Encrypt(decryptedData, newKey);
            string hashedPassword = HashUtilities.HashPassword(newPassword);
            decryptedData = CryptographicUtilities.Decrypt(encryptedData, newKey);

            RegistryData.SetUserData(this.user.Username, encryptedData);
            RegistryData.SetNewPassword(this.user.Username, hashedPassword);

            var parser = new DataParser();
            this.user.Key = newKey;
            this.user.UserData = parser.Parse(decryptedData);
        }
    }
}
