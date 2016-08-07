using PassKey.Data;

namespace PassKey.UsersActionHandlers
{
    using SecurityUtilities;

    public class LoginHandler
    {
        private DataParser dataParser;
        private LoggedUser user;

        public LoginHandler(DataParser dataParser)
        {
            this.dataParser = dataParser;
        }

        public LoggedUser Login(string username, string password)
        {
            byte[] key = HashUtilities.HashKey(password);

            string encryptedData = RegistryData.GetUserData(username);
            string rawData = CryptographicUtilities.Decrypt(encryptedData, key);

            var data = this.dataParser.Parse(rawData);

            this.user = new LoggedUser(username, key, data);

            return this.user;
        }
    }
}