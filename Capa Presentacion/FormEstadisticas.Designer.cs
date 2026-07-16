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
            pbMasCaro = new PictureBox(); // Declaramos el PictureBox
            ((System.ComponentModel.ISupportInitialize)pbMasCaro).BeginInit();
            SuspendLayout();
            // 
            // lblTituloVentana
            // 
            lblTituloVentana.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            lblTituloVentana.Location = new Point(20, 20);
            lblTituloVentana.Name = "lblTituloVentana";
            lblTituloVentana.Size = new Size(540, 30); // Agrandado para abarcar el nuevo ancho
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
            lblMasCaro.Size = new Size(320, 75); // Agrandamos el alto para que el texto de dos líneas no se corte
            lblMasCaro.TabIndex = 4;
            lblMasCaro.Text = "Videojuego más costoso: N/A";
            // 
            // pbMasCaro
            // 
            pbMasCaro.BorderStyle = BorderStyle.FixedSingle;
            pbMasCaro.Location = new Point(370, 70); // Ubicado arriba a la derecha de los datos
            pbMasCaro.Name = "pbMasCaro";
            pbMasCaro.Size = new Size(180, 180); // Tamaño ideal para la portada
            pbMasCaro.TabIndex = 6;
            pbMasCaro.TabStop = false;
            // 
            // btnCerrar
            // 
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Location = new Point(230, 280); // Centrado con respecto al nuevo ancho del formulario
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(120, 35);
            btnCerrar.TabIndex = 5;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FormEstadisticas
            // 
            // Ampliamos el ancho de 380 a 580 píxeles para acomodar el PictureBox
            ClientSize = new Size(580, 340);
            Controls.Add(lblTituloVentana);
            Controls.Add(lblTotalJuegos);
            Controls.Add(lblStockTotal);
            Controls.Add(lblValorInventario);
            Controls.Add(lblMasCaro);
            Controls.Add(pbMasCaro); // Añadimos el PictureBox a los controles del formulario
            Controls.Add(btnCerrar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormEstadisticas";
            Text = "Estadísticas del Sistema";
            Load += FormEstadisticas_Load;
            ((System.ComponentModel.ISupportInitialize)pbMasCaro).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTituloVentana;
        private System.Windows.Forms.Label lblTotalJuegos;
        private System.Windows.Forms.Label lblStockTotal;
        private System.Windows.Forms.Label lblValorInventario;
        private System.Windows.Forms.Label lblMasCaro;
        private System.Windows.Forms.Button btnCerrar;
        // Definición de nuestro nuevo control de imagen
        private System.Windows.Forms.PictureBox pbMasCaro;
    }
}