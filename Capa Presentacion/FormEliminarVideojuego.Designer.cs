namespace Capa_Presentacion
{
    partial class FormEliminarVideojuego
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblId = new Label();
            txtId = new TextBox();
            btnEliminar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.Location = new Point(30, 40);
            lblId.Name = "lblId";
            lblId.Size = new Size(120, 20);
            lblId.TabIndex = 0;
            lblId.Text = "ID del Videojuego:";
            // 
            // txtId
            // 
            txtId.Location = new Point(160, 37);
            txtId.Name = "txtId";
            txtId.Size = new Size(180, 23);
            txtId.TabIndex = 1;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(190, 90);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(110, 35);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(60, 90);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(110, 35);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormEliminarVideojuego
            // 
            ClientSize = new Size(380, 160);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Controls.Add(btnEliminar);
            Controls.Add(btnCancelar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormEliminarVideojuego";
            Text = "Eliminar Videojuego del Inventario";
            Load += FormEliminarVideojuego_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
    }
}