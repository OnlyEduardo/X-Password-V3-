
namespace X_Password.View
{
    partial class RegisterView
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
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSiteUrl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonEditRegister = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonCopySite = new System.Windows.Forms.Button();
            this.buttonCopyLogin = new System.Windows.Forms.Button();
            this.buttonCopyMail = new System.Windows.Forms.Button();
            this.buttonCopyPass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(53, 213);
            this.textBoxPassword.MaxLength = 50;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.ReadOnly = true;
            this.textBoxPassword.Size = new System.Drawing.Size(341, 26);
            this.textBoxPassword.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(52, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Senha";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(53, 168);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.ReadOnly = true;
            this.textBoxEmail.Size = new System.Drawing.Size(341, 26);
            this.textBoxEmail.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(52, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "E-mail";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLogin.Location = new System.Drawing.Point(55, 123);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.ReadOnly = true;
            this.textBoxLogin.Size = new System.Drawing.Size(339, 26);
            this.textBoxLogin.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(50, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Login";
            // 
            // textBoxSiteUrl
            // 
            this.textBoxSiteUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSiteUrl.Location = new System.Drawing.Point(55, 78);
            this.textBoxSiteUrl.Name = "textBoxSiteUrl";
            this.textBoxSiteUrl.ReadOnly = true;
            this.textBoxSiteUrl.Size = new System.Drawing.Size(339, 26);
            this.textBoxSiteUrl.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(52, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Site url";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.Location = new System.Drawing.Point(55, 35);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new System.Drawing.Size(420, 26);
            this.textBoxDescription.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(52, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Descrição";
            // 
            // buttonEditRegister
            // 
            this.buttonEditRegister.Location = new System.Drawing.Point(12, 285);
            this.buttonEditRegister.Name = "buttonEditRegister";
            this.buttonEditRegister.Size = new System.Drawing.Size(91, 23);
            this.buttonEditRegister.TabIndex = 29;
            this.buttonEditRegister.Text = "Editar registro";
            this.buttonEditRegister.UseVisualStyleBackColor = true;
            this.buttonEditRegister.Click += new System.EventHandler(this.ButtonEditRegister_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(217, 266);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(128, 42);
            this.buttonExit.TabIndex = 30;
            this.buttonExit.Text = "Sair";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // buttonCopySite
            // 
            this.buttonCopySite.Location = new System.Drawing.Point(400, 78);
            this.buttonCopySite.Name = "buttonCopySite";
            this.buttonCopySite.Size = new System.Drawing.Size(75, 26);
            this.buttonCopySite.TabIndex = 31;
            this.buttonCopySite.Text = "Copiar";
            this.buttonCopySite.UseVisualStyleBackColor = true;
            this.buttonCopySite.Click += new System.EventHandler(this.ButtonCopySite_Click);
            // 
            // buttonCopyLogin
            // 
            this.buttonCopyLogin.Location = new System.Drawing.Point(400, 124);
            this.buttonCopyLogin.Name = "buttonCopyLogin";
            this.buttonCopyLogin.Size = new System.Drawing.Size(75, 26);
            this.buttonCopyLogin.TabIndex = 32;
            this.buttonCopyLogin.Text = "Copiar";
            this.buttonCopyLogin.UseVisualStyleBackColor = true;
            this.buttonCopyLogin.Click += new System.EventHandler(this.ButtonCopyLogin_Click);
            // 
            // buttonCopyMail
            // 
            this.buttonCopyMail.Location = new System.Drawing.Point(400, 168);
            this.buttonCopyMail.Name = "buttonCopyMail";
            this.buttonCopyMail.Size = new System.Drawing.Size(75, 26);
            this.buttonCopyMail.TabIndex = 33;
            this.buttonCopyMail.Text = "Copiar";
            this.buttonCopyMail.UseVisualStyleBackColor = true;
            this.buttonCopyMail.Click += new System.EventHandler(this.ButtonCopyMail_Click);
            // 
            // buttonCopyPass
            // 
            this.buttonCopyPass.Location = new System.Drawing.Point(400, 214);
            this.buttonCopyPass.Name = "buttonCopyPass";
            this.buttonCopyPass.Size = new System.Drawing.Size(75, 26);
            this.buttonCopyPass.TabIndex = 34;
            this.buttonCopyPass.Text = "Copiar";
            this.buttonCopyPass.UseVisualStyleBackColor = true;
            this.buttonCopyPass.Click += new System.EventHandler(this.ButtonCopyPass_Click);
            // 
            // RegisterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 320);
            this.Controls.Add(this.buttonCopyPass);
            this.Controls.Add(this.buttonCopyMail);
            this.Controls.Add(this.buttonCopyLogin);
            this.Controls.Add(this.buttonCopySite);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonEditRegister);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSiteUrl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(543, 359);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(543, 359);
            this.Name = "RegisterView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSiteUrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonEditRegister;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonCopySite;
        private System.Windows.Forms.Button buttonCopyLogin;
        private System.Windows.Forms.Button buttonCopyMail;
        private System.Windows.Forms.Button buttonCopyPass;
    }
}