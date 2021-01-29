using System;
using System.Windows.Forms;
using X_Password.Data;
using X_Password.Registers;

namespace X_Password.View
{
    public partial class AddCategory : Form
    {
        private bool _isRename = false;
 
        public AddCategory() : this(null) { }

        public AddCategory(Category categoryToRename)
        {
            InitializeComponent();
            _isRename = categoryToRename != null;
            CategoryToRename = categoryToRename;

            label1.Text = _isRename 
                ? $"Deseja alterar o nome da categoria {CategoryToRename.Name} para:" 
                : "Digite o nome da nova categoria";
        }

        public Category CategoryToRename { get; }

        private void SaveCategory(Category category)
        {
            CategoryController.SaveCategory(category);
            MainForm._instance.UpdateAll();
        }

        private void CreateCategory()
        {
            var categoryName = textBox.Text;
            var exist = false;

            foreach (var catn in MainForm._instance.Categories)
                if (catn.Name.Equals(categoryName))
                    exist = true;

            if (exist)
            {
                label1.Text = $"Nome de categoria '{categoryName}' já existe, escolha outro";
                return;
            }

            Category categoryToSave;

            if (_isRename)
            {

            }

            if (_isRename)
            {
                var regs = CategoryToRename.Registers;
                categoryToSave = new Category(categoryName, regs);
                CategoryController.RemoveCategory(CategoryToRename);            
            }
            else
                categoryToSave = new Category(categoryName);

            SaveCategory(categoryToSave);
            Close();
        }

        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            CreateCategory();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CheckEnterKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
                CreateCategory();
        }
    }
}
