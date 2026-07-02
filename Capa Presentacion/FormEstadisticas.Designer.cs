namespace Capa_Presentacion
{
    partial class FormEstadisticas
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
            this.lblTituloVentana = new System.Windows.Forms.Label();
            this.lblTotalJuegos = new System.Windows.Forms.Label();
            this.lblStockTotal = new System.Windows.Forms.Label();
            this.lblValorInventario = new System.Windows.Forms.Label();
            this.lblMasCaro = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTituloVentana
            // 
            this.lblTituloVentana.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTituloVentana.Location = new System.Drawing.Point(20, 20);
            this.lblTituloVentana.Size = new System.Drawing.Size(340, 30);
            this.lblTituloVentana.Text = "Estadísticas Generales";
            this.lblTituloVentana.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTotalJuegos
            // 
            this.lblTotalJuegos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTotalJuegos.Location = new System.Drawing.Point(30, 70);
            this.lblTotalJuegos.Size = new System.Drawing.Size(320, 25);
            this.lblTotalJuegos.Text = "Modelos de juegos únicos: 0";
            // 
            // lblStockTotal
            // 
            this.lblStockTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblStockTotal.Location = new System.Drawing.Point(30, 110);
            this.lblStockTotal.Size = new System.Drawing.Size(320, 25);
            this.lblStockTotal.Text = "Total de unidades en stock: 0";
            // 
            // lblValorInventario
            // 
            this.lblValorInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblValorInventario.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblValorInventario.Location = new System.Drawing.Point(30, 150);
            this.lblValorInventario.Size = new System.Drawing.Size(320, 25);
            this.lblValorInventario.Text = "Valor total del inventario: $0.00";
            // 
            // lblMasCaro
            // 
            this.lblMasCaro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMasCaro.Location = new System.Drawing.Point(30, 190);
            this.lblMasCaro.Size = new System.Drawing.Size(320, 45);
            this.lblMasCaro.Text = "Videojuego más costoso: N/A";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(130, 260);
            this.btnCerrar.Size = new System.Drawing.Size(120, 35);
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormEstadisticas
            // 
            this.ClientSize = new System.Drawing.Size(380, 320);
            this.Controls.Add(this.lblTituloVentana);
            this.Controls.Add(this.lblTotalJuegos);
            this.Controls.Add(this.lblStockTotal);
            this.Controls.Add(this.lblValorInventario);
            this.Controls.Add(this.lblMasCaro);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormEstadisticas";
            this.Text = "Estadísticas del Sistema";
            this.Load += new System.EventHandler(this.FormEstadisticas_Load);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTituloVentana;
        private System.Windows.Forms.Label lblTotalJuegos;
        private System.Windows.Forms.Label lblStockTotal;
        private System.Windows.Forms.Label lblValorInventario;
        private System.Windows.Forms.Label lblMasCaro;
        private System.Windows.Forms.Button btnCerrar;
    }
}