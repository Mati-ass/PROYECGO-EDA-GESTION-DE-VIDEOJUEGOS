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
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblPlataforma = new System.Windows.Forms.Label();
            this.txtPlataforma = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(30, 30);
            this.lblId.Text = "ID del Videojuego:";
            this.lblId.Size = new System.Drawing.Size(120, 20);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(160, 27);
            this.txtId.Size = new System.Drawing.Size(180, 20);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(30, 70);
            this.lblTitulo.Text = "Título:";
            this.lblTitulo.Size = new System.Drawing.Size(120, 20);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(160, 67);
            this.txtTitulo.Size = new System.Drawing.Size(180, 20);
            // 
            // lblPlataforma
            // 
            this.lblPlataforma.Location = new System.Drawing.Point(30, 110);
            this.lblPlataforma.Text = "Plataforma:";
            this.lblPlataforma.Size = new System.Drawing.Size(120, 20);
            // 
            // txtPlataforma
            // 
            this.txtPlataforma.Location = new System.Drawing.Point(160, 107);
            this.txtPlataforma.Size = new System.Drawing.Size(180, 20);
            // 
            // lblCategoria
            // 
            this.lblCategoria.Location = new System.Drawing.Point(30, 150);
            this.lblCategoria.Text = "Categoría:";
            this.lblCategoria.Size = new System.Drawing.Size(120, 20);
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(160, 147);
            this.txtCategoria.Size = new System.Drawing.Size(180, 20);
            // 
            // lblStock
            // 
            this.lblStock.Location = new System.Drawing.Point(30, 190);
            this.lblStock.Text = "Stock Inicial:";
            this.lblStock.Size = new System.Drawing.Size(120, 20);
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(160, 187);
            this.txtStock.Size = new System.Drawing.Size(180, 20);
            // 
            // lblPrecio
            // 
            this.lblPrecio.Location = new System.Drawing.Point(30, 230);
            this.lblPrecio.Text = "Precio:";
            this.lblPrecio.Size = new System.Drawing.Size(120, 20);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(160, 227);
            this.txtPrecio.Size = new System.Drawing.Size(180, 20);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(80, 280);
            this.btnGuardar.Size = new System.Drawing.Size(100, 35);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(200, 280);
            this.btnCancelar.Size = new System.Drawing.Size(100, 35);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormRegistrarVideojuego
            // 
            this.ClientSize = new System.Drawing.Size(380, 350);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblPlataforma);
            this.Controls.Add(this.txtPlataforma);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRegistrarVideojuego";
            this.Text = "Registrar Nuevo Videojuego";
            this.ResumeLayout(false);
            this.PerformLayout();
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
    }
}