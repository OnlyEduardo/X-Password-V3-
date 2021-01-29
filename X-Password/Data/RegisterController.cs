using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using X_Password.Registers;

namespace X_Password.Data
{
    class RegisterController
    {
        private static readonly string FolderPath = 
            $"{Environment.GetLogicalDrives()[0]}Users/Public/{Properties.Resources.AppName}/Data";

        public static void SaveRegister(Register reg, string path)
        {
            UpdateMasterPassOfRegister(reg, path, MasterPasswordController.ExtractMasterPass());
        }

        public static void UpdateMasterPassOfRegister(Register reg, string path, string hashmaster)
        {
            var bf = new BinaryFormatter();
            FileStream file;

            try
            {
                file = File.Create(path);
            }
            catch { return; }

            var data = new Data()
            {
                _register = reg,
                _fromMasterPass = hashmaster
            };

            data._register.Name = Encrypt(data._register.Name);
            data._register.Description = Encrypt(data._register.Description);
            data._register.SiteUrl = Encrypt(data._register.SiteUrl);
            data._register.Login = Encrypt(data._register.Login);
            data._register.Email = Encrypt(data._register.Email);
            data._register.Password = Encrypt(data._register.Password);

            bf.Serialize(file, data);
            file.Dispose();
            file.Close();
        }

        public static Register ReadRegister(string path)
        {
            if (!File.Exists(path))
                return null;

            var bf = new BinaryFormatter();
            var file = File.Open(path, FileMode.Open);

            Data data;

            try
            {
                data = (Data)bf.Deserialize(file);
            } catch { return null; }

            file.Dispose();
            file.Close();

            data._register.Name = Decrypt(data._register.Name);
            data._register.Description = Decrypt(data._register.Description);
            data._register.SiteUrl = Decrypt(data._register.SiteUrl);
            data._register.Login = Decrypt(data._register.Login);
            data._register.Email = Decrypt(data._register.Email);
            data._register.Password = Decrypt(data._register.Password);

            return data._fromMasterPass.Equals(MasterPasswordController.ExtractMasterPass())
                ? data._register
                : null;
        }

        public static void RemoveRegister(string fromCategoryName, Register selectedRegister)
        {
            var pathToCat = Path.Combine(FolderPath, fromCategoryName);
            var path = Path.Combine(pathToCat, selectedRegister.Name + ".dat");

            if (!Directory.Exists(pathToCat)) return;

            if (File.Exists(path))
                File.Delete(path);
        }

        private static string Encrypt(string text)
        {
            try
            {
                return Convert.ToBase64String(
                ProtectedData.Protect(Encoding.Unicode.GetBytes(text), null, DataProtectionScope.CurrentUser));
            }
            catch { return null; }
        }

        private static string Decrypt(string text)
        {
            try
            {
                return Encoding.Unicode.GetString(
                ProtectedData.Unprotect(Convert.FromBase64String(text), null, DataProtectionScope.CurrentUser));
            } catch { return null; }
        }

        [Serializable]
        private class Data
        {
            public string _fromMasterPass;
            public Register _register;
        }   
    }
}
