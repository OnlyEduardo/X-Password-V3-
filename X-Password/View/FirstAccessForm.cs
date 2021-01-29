using System;
using System.Linq;
using System.Windows.Forms;
using X_Password.Data;

namespace X_Password.View
{
    public partial class FirstAccessForm : Form
    {
        public FirstAccessForm()
        {
            InitializeComponent();
            Text = $"Bem vindo(a) ao {Properties.Resources.AppName}";
            labelTitle.Text = Text;
            Icon = Properties.Resources.icon;
            labelVersion.Text = Properties.Resources.Version;
        }

        private void ValidatePassword()
        {
            if (textBox1.Text.Equals(textBox2.Text))
            {
                var pstatus = IsPasswordStrong(textBox1.Text);

                switch (pstatus)
                {
                    case PasswordStatus.Nice:
                        MasterPasswordController.Save(textBox1.Text);
                        MessageBox.Show("O programa vai reiniciar agora", "Aviso", MessageBoxButtons.OK);
                        Application.Restart();
                        break;
                    case PasswordStatus.WithoutEspecial:
                        ShowError("Senha não possuí caracteres especiais, coloque ao menos um:\n\n" +
                            "!, @, #, $, %, &, *");
                        break;
                    case PasswordStatus.WithoutNumbers:
                        ShowError("Senha não possuí nenhum número, coloque ao menos um");
                        break;
                    case PasswordStatus.TooShort:
                        ShowError("Senha é muito curta, deve ser maior ou igual a 8 caracteres");
                        break;
                    case PasswordStatus.TooLong:
                        ShowError("Senha é muito grande, deve ser menor que 50 caracteres");
                        break;
                    default:
                        ShowError($"Erro desconhecido: {pstatus}");
                        break;
                }
            }
            else
                ShowError("Senhas não coincidem");
        }
        private void ShowError(string text)
        {
            MessageBox.Show(text, "Erro", MessageBoxButtons.OK);
        }
        private PasswordStatus IsPasswordStrong(string pass)
        {
            var haveEspecial = false;
            var haveNumbers = false;
            var especialCharList = new char[] { '!', '@', '#', '$', '%', '&', '*' };           
            var numbersList = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach (var echar in especialCharList)
                if (pass.Contains(echar)) haveEspecial = true;

            foreach (var numb in numbersList)
                if (pass.Contains(numb.ToString())) haveNumbers = true ;

            if (pass.Length < 8) return PasswordStatus.TooShort;
            if (pass.Length > 50) return PasswordStatus.TooLong;
            if (!haveEspecial) return PasswordStatus.WithoutEspecial;
            if (!haveNumbers) return PasswordStatus.WithoutNumbers;       

            return PasswordStatus.Nice;
        }

        private void ValidatePassword(object sender, EventArgs e) => ValidatePassword();
        private void CheckBox1_CheckedChanged(object sender, EventArgs e) => textBox1.PasswordChar = checkBox1.Checked ? '\0' : '*';
        private void CheckBox2_CheckedChanged(object sender, EventArgs e) => textBox2.PasswordChar = checkBox2.Checked ? '\0' : '*';

        private void CheckEnterKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
                ValidatePassword();
        }
    }
}
