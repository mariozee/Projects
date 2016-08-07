using PassKey.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassKey.UsersActionHandlers
{
    using Exceptions;
    using SecurityUtilities;

    public class RestoreHandler
    {
        public void Restore()
        {
            if (!File.Exists(GlobalMessages.BackupFileName))
            {
                throw new PassKeyException(GlobalMessages.MissingBackupFile);
            }

            string[] encryped = File.ReadAllLines(GlobalMessages.BackupFileName);
            string[] backup = new string[encryped.Length];
            byte[] key = ASCIIEncoding.ASCII.GetBytes(Constants.BackupString);

            for (int i = 0; i < encryped.Length; i++)
            {
                backup[i] = CryptographicUtilities.Decrypt(encryped[i], key);
            }

            string subKey = Constants.UsersDataSubKey;
            string usersLog = backup[backup.Length / 2 - 1];
            for (int i = 0; i < backup.Length; i+=2)
            {
                if (i >= backup.Length / 2)
                {
                    subKey = Constants.UsersLoginInfoSubKey;                    
                }

                RegistryData.RestoreBackup(subKey, backup[i], backup[i + 1]);
            }            

            File.Delete(GlobalMessages.BackupFileName);
        }
    }
}
