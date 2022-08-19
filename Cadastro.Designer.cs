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
            this.Senha = new System.Windows.Forms.TextBox();
            this.enterBtn = new System.Windows.Forms.Button();
            this.newUser = new System.Windows.Forms.Button();
            this.Email = new System.Windows.Forms.TextBox();
            this.User = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.User)).BeginInit();
            this.SuspendLayout();
            // 
            // Senha
            // 
            resources.ApplyResources(this.Senha, "Senha");
            this.Senha.Name = "Senha";
            this.Senha.TextChanged += new System.EventHandler(this.Senha_TextChanged);
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
            resources.ApplyResources(this.Email, "Email");
            this.Email.Name = "Email";
            this.Email.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // User
            // 
            resources.ApplyResources(this.User, "User");
            this.User.Image = global::Project.Properties.Resources.users;
            this.User.Name = "User";
            this.User.TabStop = false;
            this.User.Click += new System.EventHandler(this.User_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.User);
            this.Controls.Add(this.newUser);
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.Email);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.User)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Senha;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.Button newUser;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.PictureBox User;
        private System.Windows.Forms.Label label1;
    }
}

