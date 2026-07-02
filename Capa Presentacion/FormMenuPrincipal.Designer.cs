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
            lblBienvenida.Font = new Font("Segoe UI", 20F);
            lblBienvenida.Location = new Point(133, 79);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(406, 46);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "Bienvenido a Nova Sistem";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(142, 285);
            btnRegistrar.Margin = new Padding(3, 4, 3, 4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(86, 31);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(163, 461);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(86, 31);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnEstadisticas
            // 
            btnEstadisticas.Location = new Point(465, 305);
            btnEstadisticas.Margin = new Padding(3, 4, 3, 4);
            btnEstadisticas.Name = "btnEstadisticas";
            btnEstadisticas.Size = new Size(86, 31);
            btnEstadisticas.TabIndex = 3;
            btnEstadisticas.Text = "Estadisticas";
            btnEstadisticas.UseVisualStyleBackColor = true;
            btnEstadisticas.Click += btnEstadistic_Click;
            // 
            // btnRanking
            // 
            btnRanking.Location = new Point(465, 461);
            btnRanking.Margin = new Padding(3, 4, 3, 4);
            btnRanking.Name = "btnRanking";
            btnRanking.Size = new Size(86, 31);
            btnRanking.TabIndex = 4;
            btnRanking.Text = "Ranking";
            btnRanking.UseVisualStyleBackColor = true;
            btnRanking.Click += btnRanking_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(766, 305);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(86, 31);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(766, 461);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 31);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnEliminar);
            Controls.Add(btnSalir);
            Controls.Add(btnRanking);
            Controls.Add(btnEstadisticas);
            Controls.Add(btnBuscar);
            Controls.Add(btnRegistrar);
            Controls.Add(lblBienvenida);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMenuPrincipal";
            Text = "Form2";
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