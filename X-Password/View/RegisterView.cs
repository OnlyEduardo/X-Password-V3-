using System;
using System.Windows.Forms;
using X_Password.Registers;

namespace X_Password.View
{
    public partial class RegisterView : Form
    {
        public RegisterView(Register current)
        {
            InitializeComponent();
            Current = current;
            Icon = Properties.Resources.icon;
            Text = $"Registro: {Current.Name}";

            textBoxDescription.Text = Current.Description;
            textBoxSiteUrl.Text = Current.SiteUrl;
            textBoxLogin.Text = Current.Login;
            textBoxEmail.Text = Current.Email;
            textBoxPassword.Text = Current.Password;

            CheckAvaliabilityOfTextBox(textBoxDescription, label2, null);
            CheckAvaliabilityOfTextBox(textBoxSiteUrl, label3, buttonCopySite);
            CheckAvaliabilityOfTextBox(textBoxEmail, label6, buttonCopyMail);
        }

        public Register Current { get; }

        private void CheckAvaliabilityOfTextBox(TextBox textBox, Label label, Button button)
        {
            var text = textBox.Text;

            if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text))
            {
                textBox.Visible = false;
                label.Visible = false;

                if(button != null)
                    button.Visible = false;
            }
        }

        private void ButtonEditRegister_Click(object sender, EventArgs e)
        {
            MainForm._instance.SelectedRegister = Current;
            MainForm._instance.EditRegister();            
            Close();
        }

        private void ButtonCopyPass_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxPassword.Text);
        }
        private void ButtonCopyMail_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxEmail.Text);
        }
        private void ButtonCopyLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxLogin.Text);
        }
        private void ButtonCopySite_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxSiteUrl.Text);
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
