using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using X_Password.Data;
using X_Password.Registers;

namespace X_Password.View
{
    public partial class MainForm : Form
    {
        public static MainForm _instance;

        private bool _clickedInNotifyIcon = false;

        private AddCategory _addCategoryForm = null;
        private AddRegister _addRegisterForm = null;
        private RegisterView _registerView = null;

        public MainForm()
        {
            InitializeComponent();

            if (_instance == null)
                _instance = this;

            Text = Properties.Resources.AppName;
            Icon = Properties.Resources.icon;
            labelVersion.Text = Properties.Resources.Version;
            Categories = CategoryController.LoadCategories() ?? new List<Category>();
            CreateNotifyIcon();
            UpdateAll();
        }

        private NotifyIcon NotifyIcon { get; set; }
        public List<Category> Categories { get; set; } = new List<Category>();
        public List<Register> FilteredRegisters { get; set; } = new List<Register>();
        public Category SelectedCategory { get; set; }
        public Register SelectedRegister { get; set; }

        private void CreateNotifyIcon()
        {
            NotifyIcon = new NotifyIcon
            {
                Visible = false,
                Icon = Properties.Resources.icon,
                BalloonTipIcon = ToolTipIcon.Info,
                BalloonTipTitle = $"{Properties.Resources.AppName} {Properties.Resources.Version}",
                BalloonTipText = $"{Properties.Resources.AppName} está rodando em segundo plano",

                ContextMenu = new ContextMenu(new MenuItem[]
                {
                    new MenuItem("Abrir", NormalizeWindow),
                    new MenuItem("Sobre", About_Button),
                    new MenuItem("Site", Site_Button),
                    new MenuItem("Sair", ExitApplication),                 
                }),

                Text = Properties.Resources.AppName,
            };
        }

        private void NormalizeWindow(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            NotifyIcon.Visible = false;
            _clickedInNotifyIcon = false;
            Show();
        }

        private void ExitApplication(object sender, EventArgs e)
        {
            _clickedInNotifyIcon = true;
            NotifyIcon.Visible = false;
            Application.Exit();
        }

        public void UpdateAll()
        {
            Categories.Clear();
            listBoxCategories.Items.Clear();
            Categories = CategoryController.LoadCategories();
            listBoxCategories.Items.AddRange(Categories.ToArray());
            SelectedCategory = Categories.Count > 0 ? Categories[0] : null;
            SelectedRegister = null;
            UpdateRegisterListBox();
        }
        
        public void UpdateRegisterListBox()
        {
            listBoxRegisters.Items.Clear();
            if(SelectedCategory != null)
                listBoxRegisters.Items.AddRange(SelectedCategory.Registers.ToArray());
        }

        public void EditRegister()
        {
            if (_addRegisterForm != null)
                _addRegisterForm.Close();

            if (SelectedRegister == null)
            {
                MessageBox.Show("Selecione um registro para edita-lo", "Aviso", MessageBoxButtons.OK);
                return;
            }

            _addRegisterForm = new AddRegister(SelectedRegister);
            _addRegisterForm.Show();
        }

        private void SeeRegister()
        {
            if (_registerView != null)
                _registerView.Close();

            _registerView = new RegisterView(SelectedRegister);
            _registerView.Show();
        }

        private void Search()
        {
            var text = textBox1.Text;

            if(string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text))
            {
                UpdateAll();
                return;
            }

            FilteredRegisters.Clear();
            listBoxRegisters.Items.Clear();

            foreach(var cat in Categories)
            {
                foreach(var reg in cat.Registers)
                {
                    if (reg.Match(text))
                        FilteredRegisters.Add(reg);
                }
            }

            listBoxRegisters.Items.AddRange(FilteredRegisters.ToArray());
        }
       
        #region ListBox
        private void ListBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCategories.SelectedIndex <= -1) return;

            var index = listBoxCategories.SelectedIndex;
            SelectedCategory = Categories[index];

            UpdateRegisterListBox();
        }
        private void ListBoxRegisters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRegisters.SelectedIndex <= -1) return;

            var index = listBoxRegisters.SelectedIndex;
            SelectedRegister = SelectedCategory.Registers[index];

            SeeRegister();
        }
        #endregion

        #region Menu
        private void AtualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            Thread.Sleep(50);
            UpdateAll();
            Thread.Sleep(50);
            WindowState = FormWindowState.Normal;
        }
        private void VerRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(SelectedRegister == null)
            {
                MessageBox.Show("Selecione um registro para visualizar", "Aviso", MessageBoxButtons.OK);
                return;
            }

            SeeRegister();
        }
        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void EditarNomeDaCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_addCategoryForm != null)
                _addCategoryForm.Close();

            if (SelectedCategory == null)
            {
                MessageBox.Show("Selecione uma categoria para renomea-la", "Aviso", MessageBoxButtons.OK);
                return;
            }

            _addCategoryForm = new AddCategory(SelectedCategory);
            _addCategoryForm.Show();
        }
        private void EditarRegistroAtualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditRegister();
        }
        private void AddCategory_Button(object sender, EventArgs e)
        {
            if (_addCategoryForm != null)
                _addCategoryForm.Close();

            _addCategoryForm = new AddCategory();
            _addCategoryForm.Show();
        }
        private void AddRegister_Button(object sender, EventArgs e)
        {
            if (_addRegisterForm != null)
                _addRegisterForm.Close();

            if(SelectedCategory == null)
            {
                MessageBox.Show("Você precisa de uma categoria selecionada para adicionar um registro", 
                    "Aviso", MessageBoxButtons.OK);
                return;
            }

            _addRegisterForm = new AddRegister();
            _addRegisterForm.Show();
        }
        private void RemoveCategory_Button(object sender, EventArgs e)
        {
            if(SelectedCategory == null)
            {
                MessageBox.Show("Selecione uma categoria para apaga-la", "Aviso", MessageBoxButtons.OK);
                return;
            }

            var dialog = MessageBox.Show("Deseja apagar a categoria " +
                $"'{SelectedCategory}' e todos os seus registros ?", "Apagar categoria", MessageBoxButtons.YesNo);

            if (dialog.Equals(DialogResult.No) || dialog.Equals(DialogResult.Cancel)) return;

            CategoryController.RemoveCategory(SelectedCategory);
            UpdateAll();
        }
        private void RemoveRegister_Button(object sender, EventArgs e)
        {
            if (SelectedRegister == null)
            {
                MessageBox.Show("Selecione um registro para apaga-lo", "Aviso", MessageBoxButtons.OK);
                return;
            }

            var dialog = MessageBox.Show($"Deseja apagar o registro '{SelectedRegister}' ?", 
                "Apagar Registro", MessageBoxButtons.YesNo);

            if (dialog.Equals(DialogResult.No) || dialog.Equals(DialogResult.Cancel)) return;

            RegisterController.RemoveRegister(SelectedCategory.Name, SelectedRegister);
            UpdateAll();
        }
        private void About_Button(object sender, EventArgs e)
        {
            MessageBox.Show($"{Properties.Resources.AppName} {Properties.Resources.Version}\n\n" +
                "Este é um software integralmente gratuíto e de uso livre.\n\n" +
                "Feito por: Eduardo Ribeiro Leal.\n" +
                "<eduardoleal.contact@gmail.com>\n", "Sobre", MessageBoxButtons.OK);
        }
        private void Site_Button(object sender, EventArgs e)
        {
            try
            {
                var myProcess = new Process();
                myProcess.StartInfo.UseShellExecute = true;
                myProcess.StartInfo.FileName = $"{Properties.Resources.MySite}";
                myProcess.Start();
            }
            catch
            {
                MessageBox.Show($"Erro ao abrir o site, tente abrir manualmente.\nLink: {Properties.Resources.MySite}",
                    "Erro inesperado");
            }
        }
        #endregion

        #region Search Methods
        private void TextBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
                Search();
        }
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            Search();
        }
        #endregion

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !_clickedInNotifyIcon;
            Hide();
            NotifyIcon.Visible = true;
            NotifyIcon.ShowBalloonTip(3000);
        }
    }
}
