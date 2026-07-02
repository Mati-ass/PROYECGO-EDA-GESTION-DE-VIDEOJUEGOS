namespace Capa_Presentacion
{
    partial class FormMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblBienvenida = new Label();
            btnRegistrar = new Button();
            btnBuscar = new Button();
            btnEstadisticas = new Button();
            btnRanking = new Button();
            btnSalir = new Button();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenida.ForeColor = SystemColors.HotTrack;
            lblBienvenida.Location = new Point(52, 59);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(409, 32);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "Bienvenido a Nova Sistem";
            lblBienvenida.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.Font = new Font("Dubai", 16F, FontStyle.Bold);
            btnRegistrar.Location = new Point(210, 301);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(179, 67);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_click;
            // 
            // btnBuscar
            // 
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.Font = new Font("Dubai", 16F, FontStyle.Bold);
            btnBuscar.Location = new Point(210, 155);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(179, 67);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnEstadisticas
            // 
            btnEstadisticas.Cursor = Cursors.Hand;
            btnEstadisticas.Font = new Font("Dubai", 16F, FontStyle.Bold);
            btnEstadisticas.Location = new Point(395, 155);
            btnEstadisticas.Name = "btnEstadisticas";
            btnEstadisticas.Size = new Size(179, 67);
            btnEstadisticas.TabIndex = 3;
            btnEstadisticas.Text = "Estadisticas";
            btnEstadisticas.UseVisualStyleBackColor = true;
            btnEstadisticas.Click += btnEstadistic_Click;
            // 
            // btnRanking
            // 
            btnRanking.Cursor = Cursors.Hand;
            btnRanking.Font = new Font("Dubai", 16F, FontStyle.Bold);
            btnRanking.Location = new Point(395, 228);
            btnRanking.Name = "btnRanking";
            btnRanking.Size = new Size(179, 67);
            btnRanking.TabIndex = 4;
            btnRanking.Text = "Ranking";
            btnRanking.UseVisualStyleBackColor = true;
            btnRanking.Click += btnRanking_Click;
            // 
            // btnSalir
            // 
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.Font = new Font("Dubai", 16F, FontStyle.Bold);
            btnSalir.Location = new Point(210, 228);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(179, 67);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Font = new Font("Dubai", 16F, FontStyle.Bold);
            btnEliminar.Location = new Point(395, 301);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(179, 67);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnSalir);
            Controls.Add(btnRanking);
            Controls.Add(btnEstadisticas);
            Controls.Add(btnBuscar);
            Controls.Add(btnRegistrar);
            Controls.Add(lblBienvenida);
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "FormMenuPrincipal";
            Text = "Nova sistem";
            Load += FormMenuPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenida;
        private Button btnRegistrar;
        private Button btnBuscar;
        private Button btnEstadisticas;
        private Button btnRanking;
        private Button btnSalir;
        private Button btnEliminar;
    }
}