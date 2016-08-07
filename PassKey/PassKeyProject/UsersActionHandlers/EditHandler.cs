namespace PassKey.UsersActionHandlers
{
    using System.Text;
    using Data;
    using SecurityUtilities;

    public class EditHandler
    {
        public void Remove(string hostName, LoggedUser user)
        {
            user.UserData.Remove(hostName);
            string userData = ComposeUserData(user);
            string encryptedData = CryptographicUtilities.Encrypt(userData, user.Key);
            RegistryData.SetUserData(user.Username, encryptedData);
        }

        public void Add(string hostName, string email, string username, string password, LoggedUser user)
        {
            string[] userInfo = new string[] { email, username, password };
            user.AddData(hostName, userInfo);
            string encryptedData = RegistryData.GetUserData(user.Username);
            string decrypted = CryptographicUtilities.Decrypt(encryptedData, user.Key);
            string updatedData = string.Format("{0}{1}{5}{2}{5}{3}{5}{4}{6}"
                , decrypted, hostName, email, username, password, Constants.InfoSplitChar, Constants.HostsSplitChar);
            string encryptedUpdatedData = CryptographicUtilities.Encrypt(updatedData, user.Key);
            RegistryData.SetUserData(user.Username, encryptedUpdatedData);
        }

        private string ComposeUserData(LoggedUser user)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var host in user.UserData.Keys)
            {
                sb.Append(host + Constants.InfoSplitChar);
                for (int i = 0; i < user.UserData[host].Length; i++)
                {
                    if (i == 2)
                    {
                        sb.Append(user.UserData[host][i] + Constants.HostsSplitChar);
                    }
                    else
                    {
                        sb.Append(user.UserData[host][i] + Constants.InfoSplitChar);
                    }
                }
            }

            return sb.ToString();
        }

    }
}