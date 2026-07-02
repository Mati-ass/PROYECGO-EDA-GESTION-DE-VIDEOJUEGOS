namespace Capa_Presentacion
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblProgramaTitulo = new Label();
            tbNameUser = new TextBox();
            tbPassword = new TextBox();
            lblNameUser = new Label();
            lblPassword = new Label();
            btnIngresar = new Button();
            SuspendLayout();
            // 
            // lblProgramaTitulo
            // 
            lblProgramaTitulo.AutoSize = true;
            lblProgramaTitulo.Font = new Font("Segoe UI", 20F);
            lblProgramaTitulo.Location = new Point(360, 63);
            lblProgramaTitulo.Name = "lblProgramaTitulo";
            lblProgramaTitulo.Size = new Size(218, 46);
            lblProgramaTitulo.TabIndex = 0;
            lblProgramaTitulo.Text = "Nova gestion";
            lblProgramaTitulo.Click += label1_Click;
            // 
            // tbNameUser
            // 
            tbNameUser.Font = new Font("Segoe UI", 12F);
            tbNameUser.Location = new Point(167, 193);
            tbNameUser.Margin = new Padding(3, 4, 3, 4);
            tbNameUser.Name = "tbNameUser";
            tbNameUser.Size = new Size(511, 34);
            tbNameUser.TabIndex = 1;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 12F);
            tbPassword.Location = new Point(167, 332);
            tbPassword.Margin = new Padding(3, 4, 3, 4);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(511, 34);
            tbPassword.TabIndex = 2;
            tbPassword.TextChanged += tbPassword_TextChanged;
            // 
            // lblNameUser
            // 
            lblNameUser.AutoSize = true;
            lblNameUser.Font = new Font("Segoe UI", 12F);
            lblNameUser.Location = new Point(167, 161);
            lblNameUser.Name = "lblNameUser";
            lblNameUser.Size = new Size(185, 28);
            lblNameUser.TabIndex = 3;
            lblNameUser.Text = "Nombre de usuario:";
            lblNameUser.Click += label2_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F);
            lblPassword.Location = new Point(165, 304);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(114, 28);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Contraseña:";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(421, 473);
            btnIngresar.Margin = new Padding(3, 4, 3, 4);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(86, 31);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnIngresar);
            Controls.Add(lblPassword);
            Controls.Add(lblNameUser);
            Controls.Add(tbPassword);
            Controls.Add(tbNameUser);
            Controls.Add(lblProgramaTitulo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            Text = "Form1";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProgramaTitulo;
        private TextBox tbNameUser;
        private TextBox tbPassword;
        private Label lblNameUser;
        private Label lblPassword;
        private Button btnIngresar;
    }
}
