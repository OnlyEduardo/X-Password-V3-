using System;
using System.Windows.Forms;
using X_Password.View;

namespace X_Password
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            InitiateCorrectForm();            
        }

        static void InitiateCorrectForm()
        {
            if (!Data.MasterPasswordController.ExistMasterPassword())
                Application.Run(new FirstAccessForm());
            else
                Application.Run(new LoginForm());
        }
    }
}
