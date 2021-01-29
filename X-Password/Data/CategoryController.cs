using System;
using System.IO;
using System.Collections.Generic;
using X_Password.Registers;

namespace X_Password.Data
{
    class CategoryController
    {
        private static readonly string FolderPath = 
            $"{Environment.GetLogicalDrives()[0]}Users/Public/{Properties.Resources.AppName}/Data";

        public static void UpdateMasterPassOfCategories(string hashmaster)
        {
            var cats = LoadCategories();

            foreach(var cat in cats)
            {
                var path = Path.Combine(FolderPath, cat.Name);

                foreach(var reg in cat.Registers)
                {
                    RegisterController.UpdateMasterPassOfRegister(reg, path, hashmaster);
                }
            }
        }

        public static void SaveCategory(Category category)
        {
            var path = Path.Combine(FolderPath, category.Name);

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            foreach(var reg in category.Registers)
                RegisterController.SaveRegister(reg, $"{path}/{reg.Name}.dat");
        }

        public static void RemoveCategory(Category category)
        {
            var path = Path.Combine(FolderPath, category.Name);

            if (Directory.Exists(path))
                Directory.Delete(path, true);
        }

        public static List<Category> LoadCategories()
        {
            if (!Directory.Exists(FolderPath))
                Directory.CreateDirectory(FolderPath);

            var fileCats = Directory.GetDirectories(FolderPath);
            var categories = new List<Category>();

            foreach (var filecat in fileCats)
            {
                var regs = new List<Register>();
                var fileRegs = Directory.GetFiles(filecat);
 
                foreach(var filereg in fileRegs)
                {
                    var reg = RegisterController.ReadRegister(filereg);
                    if(reg != null)
                        regs.Add(reg);
                }

                var sep = filecat.Split('\\');
                var name = sep[sep.Length - 1];
                categories.Add(new Category(name, regs));
            }

            return categories;
        }
    }
}
