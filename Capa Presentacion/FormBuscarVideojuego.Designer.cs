namespace Capa_Presentacion
{
    partial class FormBuscarVideojuego
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pbCaratulaBuscar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaratulaBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(30, 30);
            this.lblId.Text = "Ingresa el ID a buscar:";
            this.lblId.Size = new System.Drawing.Size(120, 20);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(160, 27);
            this.txtId.Size = new System.Drawing.Size(180, 20);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(160, 60);
            this.btnBuscar.Size = new System.Drawing.Size(180, 30);
            this.btnBuscar.Text = "Buscar en Inventario";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.Location = new System.Drawing.Point(30, 110);
            this.lblResultado.Text = "Datos del Videojuego:";
            this.lblResultado.Size = new System.Drawing.Size(120, 20);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(30, 135);
            this.txtResultado.Multiline = true;
            this.txtResultado.ReadOnly = true;
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultado.Size = new System.Drawing.Size(310, 180);
            // 
            // pbCaratulaBuscar
            // 
            this.pbCaratulaBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCaratulaBuscar.Location = new System.Drawing.Point(365, 135);
            this.pbCaratulaBuscar.Name = "pbCaratulaBuscar";
            this.pbCaratulaBuscar.Size = new System.Drawing.Size(180, 180);
            this.pbCaratulaBuscar.TabIndex = 6;
            this.pbCaratulaBuscar.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(235, 340);
            this.btnCerrar.Size = new System.Drawing.Size(100, 30);
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormBuscarVideojuego
            // 
            // Ampliamos el ancho a 580 para que quepa la carátula al lado derecho
            this.ClientSize = new System.Drawing.Size(580, 390);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.pbCaratulaBuscar);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormBuscarVideojuego";
            this.Text = "Buscar Videojuego";
            ((System.ComponentModel.ISupportInitialize)(this.pbCaratulaBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnCerrar;
        // Declaramos el PictureBox para que el compilador lo reconozca
        private System.Windows.Forms.PictureBox pbCaratulaBuscar;
    }
}