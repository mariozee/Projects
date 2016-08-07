namespace PassKey.UsersActionHandlers
{
    using Data;
    using SecurityUtilities;

    public class RegistrationHandler
    {
        public void Register(string username, string password)
        {
            //Uncomment and replace with string.Empty for hardocodet data for easly debug
            //string data = "google/asd@abv.bg//123456&youtube/qwer@abv.bg//654321&";

            string hashedPass = HashUtilities.HashPassword(password);
            byte[] key = HashUtilities.HashKey(password);
            string encryptedData = CryptographicUtilities.Encrypt(string.Empty, key);

            RegistryData.CreateUser(username, hashedPass, encryptedData);
        }
    }
}
