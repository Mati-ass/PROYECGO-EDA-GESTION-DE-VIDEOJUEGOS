namespace Capa_Presentacion
{
    partial class FormRegistrarVideojuego
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
            lblTitulo = new Label();
            txtTitulo = new TextBox();
            lblPlataforma = new Label();
            txtPlataforma = new TextBox();
            lblCategoria = new Label();
            txtCategoria = new TextBox();
            lblStock = new Label();
            txtStock = new TextBox();
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            btnExaminarImagen = new Button();
            pbCaratula = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbCaratula).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.Location = new Point(30, 30);
            lblId.Name = "lblId";
            lblId.Size = new Size(120, 20);
            lblId.TabIndex = 0;
            lblId.Text = "ID del Videojuego:";
            // 
            // txtId
            // 
            txtId.Location = new Point(160, 27);
            txtId.Name = "txtId";
            txtId.Size = new Size(180, 23);
            txtId.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.Location = new Point(30, 70);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(120, 20);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Título:";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(160, 67);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(180, 23);
            txtTitulo.TabIndex = 3;
            // 
            // lblPlataforma
            // 
            lblPlataforma.Location = new Point(30, 110);
            lblPlataforma.Name = "lblPlataforma";
            lblPlataforma.Size = new Size(120, 20);
            lblPlataforma.TabIndex = 4;
            lblPlataforma.Text = "Plataforma:";
            // 
            // txtPlataforma
            // 
            txtPlataforma.Location = new Point(160, 107);
            txtPlataforma.Name = "txtPlataforma";
            txtPlataforma.Size = new Size(180, 23);
            txtPlataforma.TabIndex = 5;
            // 
            // lblCategoria
            // 
            lblCategoria.Location = new Point(30, 150);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(120, 20);
            lblCategoria.TabIndex = 6;
            lblCategoria.Text = "Categoría:";
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(160, 147);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(180, 23);
            txtCategoria.TabIndex = 7;
            // 
            // lblStock
            // 
            lblStock.Location = new Point(30, 190);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(120, 20);
            lblStock.TabIndex = 8;
            lblStock.Text = "Stock Inicial:";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(160, 187);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(180, 23);
            txtStock.TabIndex = 9;
            // 
            // lblPrecio
            // 
            lblPrecio.Location = new Point(30, 230);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(120, 20);
            lblPrecio.TabIndex = 10;
            lblPrecio.Text = "Precio:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(160, 227);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(180, 23);
            txtPrecio.TabIndex = 11;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(205, 314);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 35);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(88, 314);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 35);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnExaminarImagen
            // 
            btnExaminarImagen.Location = new Point(160, 269);
            btnExaminarImagen.Name = "btnExaminarImagen";
            btnExaminarImagen.Size = new Size(180, 23);
            btnExaminarImagen.TabIndex = 14;
            btnExaminarImagen.Text = "Subir Imagen";
            btnExaminarImagen.UseVisualStyleBackColor = true;
            btnExaminarImagen.Click += button1_Click;
            // 
            // pbCaratula
            // 
            pbCaratula.BackColor = SystemColors.ButtonHighlight;
            pbCaratula.Location = new Point(384, 70);
            pbCaratula.Name = "pbCaratula";
            pbCaratula.Size = new Size(110, 140);
            pbCaratula.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCaratula.TabIndex = 15;
            pbCaratula.TabStop = false;
            // 
            // FormRegistrarVideojuego
            // 
            ClientSize = new Size(506, 373);
            Controls.Add(pbCaratula);
            Controls.Add(btnExaminarImagen);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Controls.Add(lblTitulo);
            Controls.Add(txtTitulo);
            Controls.Add(lblPlataforma);
            Controls.Add(txtPlataforma);
            Controls.Add(lblCategoria);
            Controls.Add(txtCategoria);
            Controls.Add(lblStock);
            Controls.Add(txtStock);
            Controls.Add(lblPrecio);
            Controls.Add(txtPrecio);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormRegistrarVideojuego";
            Text = "Registrar Nuevo Videojuego";
            Load += FormRegistrarVideojuego_Load;
            ((System.ComponentModel.ISupportInitialize)pbCaratula).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblPlataforma;
        private System.Windows.Forms.TextBox txtPlataforma;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private Button btnExaminarImagen;
        private PictureBox pbCaratula;
    }
}