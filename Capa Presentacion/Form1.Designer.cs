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
            lblProgramaTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblProgramaTitulo.AutoSize = true;
            lblProgramaTitulo.Font = new Font("Forte", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProgramaTitulo.ForeColor = SystemColors.HotTrack;
            lblProgramaTitulo.Location = new Point(280, 42);
            lblProgramaTitulo.Name = "lblProgramaTitulo";
            lblProgramaTitulo.Size = new Size(258, 44);
            lblProgramaTitulo.TabIndex = 0;
            lblProgramaTitulo.Text = "Nova gestion";
            lblProgramaTitulo.Click += label1_Click;
            // 
            // tbNameUser
            // 
            tbNameUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbNameUser.Font = new Font("Segoe UI", 12F);
            tbNameUser.ForeColor = SystemColors.WindowText;
            tbNameUser.Location = new Point(145, 145);
            tbNameUser.Name = "tbNameUser";
            tbNameUser.Size = new Size(448, 29);
            tbNameUser.TabIndex = 1;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 12F);
            tbPassword.Location = new Point(146, 249);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(448, 29);
            tbPassword.TabIndex = 2;
            tbPassword.TextChanged += tbPassword_TextChanged;
            // 
            // lblNameUser
            // 
            lblNameUser.AutoSize = true;
            lblNameUser.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNameUser.Location = new Point(146, 121);
            lblNameUser.Name = "lblNameUser";
            lblNameUser.Size = new Size(181, 18);
            lblNameUser.TabIndex = 3;
            lblNameUser.Text = "Nombre de usuario:";
            lblNameUser.Click += label2_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(144, 228);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(116, 18);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Contraseña:";
            // 
            // btnIngresar
            // 
            btnIngresar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnIngresar.Location = new Point(368, 355);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(89, 37);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 451);
            Controls.Add(btnIngresar);
            Controls.Add(lblPassword);
            Controls.Add(lblNameUser);
            Controls.Add(tbPassword);
            Controls.Add(tbNameUser);
            Controls.Add(lblProgramaTitulo);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
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
