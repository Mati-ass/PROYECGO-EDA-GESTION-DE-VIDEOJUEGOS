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
            lblTituloVentana = new Label();
            lblTotalJuegos = new Label();
            lblStockTotal = new Label();
            lblValorInventario = new Label();
            lblMasCaro = new Label();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // lblTituloVentana
            // 
            lblTituloVentana.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            lblTituloVentana.Location = new Point(20, 20);
            lblTituloVentana.Name = "lblTituloVentana";
            lblTituloVentana.Size = new Size(340, 30);
            lblTituloVentana.TabIndex = 0;
            lblTituloVentana.Text = "Estadísticas Generales";
            lblTituloVentana.TextAlign = ContentAlignment.TopCenter;
            lblTituloVentana.Click += lblTituloVentana_Click;
            // 
            // lblTotalJuegos
            // 
            lblTotalJuegos.Font = new Font("Microsoft Sans Serif", 10F);
            lblTotalJuegos.Location = new Point(30, 70);
            lblTotalJuegos.Name = "lblTotalJuegos";
            lblTotalJuegos.Size = new Size(320, 25);
            lblTotalJuegos.TabIndex = 1;
            lblTotalJuegos.Text = "Modelos de juegos únicos: 0";
            // 
            // lblStockTotal
            // 
            lblStockTotal.Font = new Font("Microsoft Sans Serif", 10F);
            lblStockTotal.Location = new Point(30, 110);
            lblStockTotal.Name = "lblStockTotal";
            lblStockTotal.Size = new Size(320, 25);
            lblStockTotal.TabIndex = 2;
            lblStockTotal.Text = "Total de unidades en stock: 0";
            // 
            // lblValorInventario
            // 
            lblValorInventario.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            lblValorInventario.ForeColor = Color.DarkGreen;
            lblValorInventario.Location = new Point(30, 150);
            lblValorInventario.Name = "lblValorInventario";
            lblValorInventario.Size = new Size(320, 25);
            lblValorInventario.TabIndex = 3;
            lblValorInventario.Text = "Valor total del inventario: $0.00";
            // 
            // lblMasCaro
            // 
            lblMasCaro.Font = new Font("Microsoft Sans Serif", 10F);
            lblMasCaro.Location = new Point(30, 190);
            lblMasCaro.Name = "lblMasCaro";
            lblMasCaro.Size = new Size(320, 45);
            lblMasCaro.TabIndex = 4;
            lblMasCaro.Text = "Videojuego más costoso: N/A";
            // 
            // btnCerrar
            // 
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Location = new Point(130, 260);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(120, 35);
            btnCerrar.TabIndex = 5;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FormEstadisticas
            // 
            ClientSize = new Size(380, 320);
            Controls.Add(lblTituloVentana);
            Controls.Add(lblTotalJuegos);
            Controls.Add(lblStockTotal);
            Controls.Add(lblValorInventario);
            Controls.Add(lblMasCaro);
            Controls.Add(btnCerrar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormEstadisticas";
            Text = "Estadísticas del Sistema";
            Load += FormEstadisticas_Load;
            ResumeLayout(false);
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