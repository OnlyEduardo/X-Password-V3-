using System;
using System.Windows.Forms;
using X_Password.Data;
using X_Password.Registers;

namespace X_Password.View
{
    public partial class AddRegister : Form
    {
        private readonly bool _isEdit = false;

        public AddRegister() : this(null) { }

        public AddRegister(Register registerToEdit)
        {
            InitializeComponent();

            _isEdit = registerToEdit != null;
            RegisterToEdit = registerToEdit;

            if (_isEdit)
            {
                Text = "Editar registro";
                buttonCreate.Text = "Editar";
                label1.Visible = false;
                textBoxName.Visible = false;
                textBoxDescription.Text = RegisterToEdit.Description;
                textBoxSiteUrl.Text = RegisterToEdit.SiteUrl;
                textBoxLogin.Text = RegisterToEdit.Login;
                textBoxEmail.Text = RegisterToEdit.Email;
                textBoxPassword.Text = RegisterToEdit.Password;
            }
        }

        public Register RegisterToEdit { get; }

        private void CreateRegister()
        {         
            var name = textBoxName.Text;
            var desc = textBoxDescription.Text;
            var site = textBoxSiteUrl.Text;
            var logn = textBoxLogin.Text;
            var mail = textBoxEmail.Text;
            var pass = textBoxPassword.Text;

            if (!ValidateRegName(name) && !_isEdit)
            {
                labelNotification.Text = "Nome do registro inválido ou já existe";
                return;
            }             
            if (!ValidateString(logn))
            {
                labelNotification.Text = "Login é um campo obrigatório";
                return;
            }
            if (!ValidatePassword(pass))
            {
                labelNotification.Text = "Campo senha inválido, deve ter entre 8 e 50 caracteres";
                return;
            }              

            var haveDesc = ValidateString(desc);
            var haveSite = ValidateString(site);
            var haveMail = ValidateString(mail);

            var reg = new Register(_isEdit ? RegisterToEdit.Name : name,
                haveDesc ? desc : "",
                haveSite ? site : "",
                logn,
                haveMail ? mail : "",
                pass);


            if (_isEdit)
            {
                MainForm._instance.SelectedCategory.Registers.Remove(RegisterToEdit);
                RegisterController.RemoveRegister(MainForm._instance.SelectedCategory.Name, RegisterToEdit);
            }

            MainForm._instance.SelectedCategory.Registers.Add(reg);
            CategoryController.SaveCategory(MainForm._instance.SelectedCategory);
            MainForm._instance.UpdateAll();
            Close();
        }

        private void ButtonCreate_Click(object sender, EventArgs e) => CreateRegister();

        private bool ValidateRegName(string input)
        {
            if (!ValidateString(input)) return false;

            foreach (var reg in MainForm._instance.SelectedCategory.Registers)
            {
                if (reg.Name.Equals(input) && !_isEdit)
                    return false;
            }

            return true;
        }

        private bool ValidatePassword(string input)
        {
            if (!ValidateString(input)) return false;
            if (input.Length < 8 || input.Length > 50) return false;

            return true;
        }

        private bool ValidateString(string input)
        {
            if (string.IsNullOrEmpty(input)) return false;
            if (string.IsNullOrWhiteSpace(input)) return false;

            return true;
        }

        private void ButtonGeneratePass_Click(object sender, EventArgs e)
        {
            var random = new Random();
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                        "abcdefghijklmnopqrstuvwxyz" +
                        "0123456789" +
                        "!@#$%&*";

            var stringChars = new char[random.Next(8, 12)];

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var passgenerated = new string(stringChars);
            textBoxPassword.Text = passgenerated;
        }

        private void ButtonCancel_Click(object sender, EventArgs e) => Close();
        private void CheckBox1_CheckedChanged(object sender, EventArgs e) => textBoxPassword.PasswordChar = checkBox1.Checked ? '\0' : '*';
        private void TextBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
                CreateRegister();
        }
        private void TextBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
                CreateRegister();
        }
        private void TextBoxLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
                CreateRegister();
        }
        private void TextBoxSiteUrl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
                CreateRegister();
        }
        private void TextBoxDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
                CreateRegister();
        }
        private void TextBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
                CreateRegister();
        }
    }
}
