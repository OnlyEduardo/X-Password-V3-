using System;
using System.Windows.Forms;
using X_Password.Data;

namespace X_Password.View
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            Text = Properties.Resources.AppName;
            labelTitle.Text = $"Bem vindo(a) ao {Properties.Resources.AppName}";
            Icon = Properties.Resources.icon;
            labelVersion.Text = Properties.Resources.Version;
        }

        private void ValidatePassword()
        {
            if (MasterPasswordController.CompareStringToMasterHash(textBox1.Text))
            {
                var registersForm = new MainForm();
                registersForm.Show();
                Hide();
            }
            else
                MessageBox.Show("Senha mestra inválida", "Senha inválida", MessageBoxButtons.OK);
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e) => textBox1.PasswordChar = checkBox1.Checked ? '\0' : '*';
        private void ButtonAcessApplication_Click(object sender, EventArgs e) => ValidatePassword();

        private void CheckEnterKeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Return)
                ValidatePassword();
        }
    }
}
