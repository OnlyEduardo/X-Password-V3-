using System.Windows.Forms;

namespace X_Password.View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCategoryText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuTopBar = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarNomeDaCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarRegistroAtualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxRegisters = new System.Windows.Forms.ListBox();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.listBoxCategories = new System.Windows.Forms.ListBox();
            this.panelTop.SuspendLayout();
            this.menuTopBar.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.labelCategoryText);
            this.panelTop.Controls.Add(this.button1);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.textBox1);
            this.panelTop.Controls.Add(this.menuTopBar);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(910, 62);
            this.panelTop.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(212, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Registros";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCategoryText
            // 
            this.labelCategoryText.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoryText.ForeColor = System.Drawing.Color.Black;
            this.labelCategoryText.Location = new System.Drawing.Point(0, 38);
            this.labelCategoryText.Name = "labelCategoryText";
            this.labelCategoryText.Size = new System.Drawing.Size(216, 23);
            this.labelCategoryText.TabIndex = 5;
            this.labelCategoryText.Text = "Categorias";
            this.labelCategoryText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(809, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(392, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar registro\r\n";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(475, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(328, 31);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxSearch_KeyPress);
            // 
            // menuTopBar
            // 
            this.menuTopBar.BackColor = System.Drawing.Color.Gainsboro;
            this.menuTopBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.editarToolStripMenuItem,
            this.adicionarToolStripMenuItem,
            this.removerToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuTopBar.Location = new System.Drawing.Point(0, 0);
            this.menuTopBar.Name = "menuTopBar";
            this.menuTopBar.Size = new System.Drawing.Size(908, 24);
            this.menuTopBar.TabIndex = 4;
            this.menuTopBar.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atualizarToolStripMenuItem,
            this.verRegistroToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(103, 20);
            this.toolStripMenuItem1.Text = "Banco de dados";
            // 
            // atualizarToolStripMenuItem
            // 
            this.atualizarToolStripMenuItem.Name = "atualizarToolStripMenuItem";
            this.atualizarToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.atualizarToolStripMenuItem.Text = "Atualizar dados";
            this.atualizarToolStripMenuItem.Click += new System.EventHandler(this.AtualizarToolStripMenuItem_Click);
            // 
            // verRegistroToolStripMenuItem
            // 
            this.verRegistroToolStripMenuItem.Name = "verRegistroToolStripMenuItem";
            this.verRegistroToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.verRegistroToolStripMenuItem.Text = "Ver registro";
            this.verRegistroToolStripMenuItem.Click += new System.EventHandler(this.VerRegistroToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarNomeDaCategoriaToolStripMenuItem,
            this.editarRegistroAtualToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // editarNomeDaCategoriaToolStripMenuItem
            // 
            this.editarNomeDaCategoriaToolStripMenuItem.Name = "editarNomeDaCategoriaToolStripMenuItem";
            this.editarNomeDaCategoriaToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.editarNomeDaCategoriaToolStripMenuItem.Text = "Editar nome da categoria";
            this.editarNomeDaCategoriaToolStripMenuItem.Click += new System.EventHandler(this.EditarNomeDaCategoriaToolStripMenuItem_Click);
            // 
            // editarRegistroAtualToolStripMenuItem
            // 
            this.editarRegistroAtualToolStripMenuItem.Name = "editarRegistroAtualToolStripMenuItem";
            this.editarRegistroAtualToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.editarRegistroAtualToolStripMenuItem.Text = "Editar registro atual";
            this.editarRegistroAtualToolStripMenuItem.Click += new System.EventHandler(this.EditarRegistroAtualToolStripMenuItem_Click);
            // 
            // adicionarToolStripMenuItem
            // 
            this.adicionarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriaToolStripMenuItem,
            this.registroToolStripMenuItem});
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.adicionarToolStripMenuItem.Text = "Adicionar";
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.categoriaToolStripMenuItem.Text = "Adicionar categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.AddCategory_Button);
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.registroToolStripMenuItem.Text = "Adicionar registro";
            this.registroToolStripMenuItem.Click += new System.EventHandler(this.AddRegister_Button);
            // 
            // removerToolStripMenuItem
            // 
            this.removerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriaToolStripMenuItem1,
            this.registroToolStripMenuItem1});
            this.removerToolStripMenuItem.Name = "removerToolStripMenuItem";
            this.removerToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.removerToolStripMenuItem.Text = "Remover";
            // 
            // categoriaToolStripMenuItem1
            // 
            this.categoriaToolStripMenuItem1.Name = "categoriaToolStripMenuItem1";
            this.categoriaToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.categoriaToolStripMenuItem1.Text = "Remover categoria";
            this.categoriaToolStripMenuItem1.Click += new System.EventHandler(this.RemoveCategory_Button);
            // 
            // registroToolStripMenuItem1
            // 
            this.registroToolStripMenuItem1.Name = "registroToolStripMenuItem1";
            this.registroToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.registroToolStripMenuItem1.Text = "Remover registro";
            this.registroToolStripMenuItem1.Click += new System.EventHandler(this.RemoveRegister_Button);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem,
            this.siteToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.About_Button);
            // 
            // siteToolStripMenuItem
            // 
            this.siteToolStripMenuItem.Name = "siteToolStripMenuItem";
            this.siteToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.siteToolStripMenuItem.Text = "Site";
            this.siteToolStripMenuItem.Click += new System.EventHandler(this.Site_Button);
            // 
            // listBoxRegisters
            // 
            this.listBoxRegisters.BackColor = System.Drawing.Color.Snow;
            this.listBoxRegisters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxRegisters.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxRegisters.ForeColor = System.Drawing.Color.Black;
            this.listBoxRegisters.FormattingEnabled = true;
            this.listBoxRegisters.HorizontalScrollbar = true;
            this.listBoxRegisters.ItemHeight = 22;
            this.listBoxRegisters.Location = new System.Drawing.Point(216, 62);
            this.listBoxRegisters.Name = "listBoxRegisters";
            this.listBoxRegisters.Size = new System.Drawing.Size(694, 424);
            this.listBoxRegisters.TabIndex = 1;
            this.listBoxRegisters.SelectedIndexChanged += new System.EventHandler(this.ListBoxRegisters_SelectedIndexChanged);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBottom.Controls.Add(this.labelVersion);
            this.panelBottom.Controls.Add(this.labelInfo);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 486);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(910, 20);
            this.panelBottom.TabIndex = 3;
            // 
            // labelVersion
            // 
            this.labelVersion.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.Location = new System.Drawing.Point(677, 0);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(233, 20);
            this.labelVersion.TabIndex = 0;
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelInfo
            // 
            this.labelInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.Location = new System.Drawing.Point(0, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(506, 20);
            this.labelInfo.TabIndex = 1;
            this.labelInfo.Text = "X-Password | By: Eduardo Ribeiro Leal | <eduardoleal.contact@gmail.com> | 2021";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxCategories
            // 
            this.listBoxCategories.BackColor = System.Drawing.Color.White;
            this.listBoxCategories.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxCategories.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCategories.ForeColor = System.Drawing.Color.Black;
            this.listBoxCategories.FormattingEnabled = true;
            this.listBoxCategories.HorizontalScrollbar = true;
            this.listBoxCategories.ItemHeight = 22;
            this.listBoxCategories.Location = new System.Drawing.Point(0, 62);
            this.listBoxCategories.Name = "listBoxCategories";
            this.listBoxCategories.Size = new System.Drawing.Size(216, 424);
            this.listBoxCategories.TabIndex = 4;
            this.listBoxCategories.SelectedIndexChanged += new System.EventHandler(this.ListBoxCategories_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 506);
            this.Controls.Add(this.listBoxRegisters);
            this.Controls.Add(this.listBoxCategories);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBottom);
            this.MainMenuStrip = this.menuTopBar;
            this.MinimumSize = new System.Drawing.Size(926, 545);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.menuTopBar.ResumeLayout(false);
            this.menuTopBar.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelTop;
        private ListBox listBoxRegisters;
        private Panel panelBottom;
        private Label labelVersion;
        private Label labelInfo;
        private ListBox listBoxCategories;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private MenuStrip menuTopBar;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem atualizarToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem adicionarToolStripMenuItem;
        private ToolStripMenuItem categoriaToolStripMenuItem;
        private ToolStripMenuItem registroToolStripMenuItem;
        private ToolStripMenuItem removerToolStripMenuItem;
        private ToolStripMenuItem categoriaToolStripMenuItem1;
        private ToolStripMenuItem registroToolStripMenuItem1;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem siteToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem editarNomeDaCategoriaToolStripMenuItem;
        private ToolStripMenuItem editarRegistroAtualToolStripMenuItem;
        private Label labelCategoryText;
        private Label label2;
        private ToolStripMenuItem verRegistroToolStripMenuItem;
    }
}