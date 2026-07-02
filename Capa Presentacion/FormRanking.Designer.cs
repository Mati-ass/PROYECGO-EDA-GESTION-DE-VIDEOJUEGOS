namespace Capa_Presentacion
{
    partial class FormRanking
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtRanking = new System.Windows.Forms.TextBox();
            this.btnTopPrecio = new System.Windows.Forms.Button();
            this.btnTopStock = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(20, 15);
            this.lblTitulo.Size = new System.Drawing.Size(360, 25);
            this.lblTitulo.Text = "Rankings del Inventario (Top 5)";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRanking
            // 
            this.txtRanking.Font = new System.Drawing.Font("Consolas", 10F);
            this.txtRanking.Location = new System.Drawing.Point(20, 95);
            this.txtRanking.Multiline = true;
            this.txtRanking.ReadOnly = true;
            this.txtRanking.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRanking.Size = new System.Drawing.Size(360, 160);
            // 
            // btnTopPrecio
            // 
            this.btnTopPrecio.Location = new System.Drawing.Point(20, 55);
            this.btnTopPrecio.Size = new System.Drawing.Size(175, 30);
            this.btnTopPrecio.Text = "Top 5 Más Caros";
            this.btnTopPrecio.UseVisualStyleBackColor = true;
            this.btnTopPrecio.Click += new System.EventHandler(this.btnTopPrecio_Click);
            // 
            // btnTopStock
            // 
            this.btnTopStock.Location = new System.Drawing.Point(205, 55);
            this.btnTopStock.Size = new System.Drawing.Size(175, 30);
            this.btnTopStock.Text = "Top 5 Mayor Stock";
            this.btnTopStock.UseVisualStyleBackColor = true;
            this.btnTopStock.Click += new System.EventHandler(this.btnTopStock_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(150, 270);
            this.btnCerrar.Size = new System.Drawing.Size(100, 30);
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormRanking
            // 
            this.ClientSize = new System.Drawing.Size(400, 320);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnTopPrecio);
            this.Controls.Add(this.btnTopStock);
            this.Controls.Add(this.txtRanking);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormRanking";
            this.Text = "Panel de Clasificaciones";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtRanking;
        private System.Windows.Forms.Button btnTopPrecio;
        private System.Windows.Forms.Button btnTopStock;
        private System.Windows.Forms.Button btnCerrar;
    }
}