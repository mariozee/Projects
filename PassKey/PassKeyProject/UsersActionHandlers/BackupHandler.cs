using PassKey.Data;
using PassKey.SecurityUtilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PassKey.UsersActionHandlers
{
    public class BackupHandler
    {
        public void Backup()
        {
            string[] backup = RegistryData.PrepareBackup().ToArray();
            string[] encrypted = new string[backup.Length];
            byte[] key = ASCIIEncoding.ASCII.GetBytes(Constants.BackupString);
            for (int i = 0; i < backup.Length; i++)
            {
                encrypted[i] = CryptographicUtilities.Encrypt(backup[i], key);
            }
    
            File.WriteAllLines("backup.dat", encrypted);            
        }        
    }
}
