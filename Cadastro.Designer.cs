namespace Project
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.enterBtn = new System.Windows.Forms.Button();
            this.newUser = new System.Windows.Forms.Button();
            this.Email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.User)).BeginInit();
            this.SuspendLayout();
            // 
            // enterBtn
            // 
            this.enterBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.enterBtn, "enterBtn");
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.UseVisualStyleBackColor = false;
            this.enterBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // newUser
            // 
            resources.ApplyResources(this.newUser, "newUser");
            this.newUser.Name = "newUser";
            this.newUser.UseVisualStyleBackColor = true;
            this.newUser.Click += new System.EventHandler(this.button2_Click);
            // 
            // Email
            // 
            this.Email.AcceptsTab = true;
            resources.ApplyResources(this.Email, "Email");
            this.Email.Name = "Email";
            this.Email.ShortcutsEnabled = false;
            this.Email.TextChanged += new System.EventHandler(this.textBox1);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // passwordLabel
            // 
            resources.ApplyResources(this.passwordLabel, "passwordLabel");
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // emailLabel
            // 
            resources.ApplyResources(this.emailLabel, "emailLabel");
            this.emailLabel.Name = "emailLabel";
            // 
            // User
            // 
            resources.ApplyResources(this.User, "User");
            this.User.Image = global::Project.Properties.Resources.entrar;
            this.User.Name = "User";
            this.User.TabStop = false;
            this.User.Click += new System.EventHandler(this.User_Click);
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.User);
            this.Controls.Add(this.newUser);
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.Email);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.User)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.Button newUser;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.PictureBox User;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label emailLabel;
    }
}

