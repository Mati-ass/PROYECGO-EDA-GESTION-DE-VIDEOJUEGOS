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
            lblBienvenida.Location = new Point(116, 59);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(325, 37);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "Bienvenido a Nova Sistem";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(143, 229);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(143, 346);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnEstadisticas
            // 
            btnEstadisticas.Location = new Point(407, 229);
            btnEstadisticas.Name = "btnEstadisticas";
            btnEstadisticas.Size = new Size(75, 23);
            btnEstadisticas.TabIndex = 3;
            btnEstadisticas.Text = "Estadisticas";
            btnEstadisticas.UseVisualStyleBackColor = true;
            // 
            // btnRanking
            // 
            btnRanking.Location = new Point(407, 346);
            btnRanking.Name = "btnRanking";
            btnRanking.Size = new Size(75, 23);
            btnRanking.TabIndex = 4;
            btnRanking.Text = "Ranking";
            btnRanking.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(670, 229);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(670, 346);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnSalir);
            Controls.Add(btnRanking);
            Controls.Add(btnEstadisticas);
            Controls.Add(btnBuscar);
            Controls.Add(btnRegistrar);
            Controls.Add(lblBienvenida);
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