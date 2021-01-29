using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace X_Password.Data
{
    class MasterPasswordController
    {
        private static readonly string FolderPath = $"{Environment.GetLogicalDrives()[0]}Users/Public/{Properties.Resources.AppName}";
        private static readonly string DataArchiveName = "Configuration.dat";

        public static string StringSha256Hash(string text) => BitConverter
            .ToString(new SHA256Managed().ComputeHash(Encoding.UTF8.GetBytes(text))).Replace("-", string.Empty);

        public static string ExtractMasterPass()
        {
            var arq = File.OpenText(Path.Combine(FolderPath, DataArchiveName));
            var loadedHash = arq.ReadLine();
            arq.Dispose();
            arq.Close();

            return loadedHash;
        }
   
        public static void Save(string masterPass)
        {
            var hash = StringSha256Hash(masterPass);

            if (!Directory.Exists(FolderPath))
                Directory.CreateDirectory(FolderPath);

            try
            {
                if (File.Exists(Path.Combine(FolderPath, DataArchiveName)))
                    File.Delete(Path.Combine(FolderPath, DataArchiveName));

                var arq = File.CreateText(Path.Combine(FolderPath, DataArchiveName));

                arq.AutoFlush = true;

                arq.Write(hash);
                arq.Dispose();
                arq.Close();

            } catch (IOException e) {
                System.Windows.Forms.MessageBox.Show(e.Message, "Erro", System.Windows.Forms.MessageBoxButtons.OK);
            }    
        }

        public static bool ExistMasterPassword()
        {
            if (!Directory.Exists(FolderPath))
                return false;

            var arq = File.OpenText(Path.Combine(FolderPath, DataArchiveName));
            var text = arq.ReadLine();
            arq.Dispose();
            arq.Close();

            if (string.IsNullOrEmpty(text)) return false;

            return text.Length == 64;
        }

        public static bool CompareStringToMasterHash(string simpleString)
        {
            if (string.IsNullOrEmpty(simpleString)) return false;

            return ExtractMasterPass() == StringSha256Hash(simpleString);
        }
    }
}
