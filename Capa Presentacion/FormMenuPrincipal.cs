using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class FormMenuPrincipal : Form
    {
        
        private string rolUsuario;

      
        public FormMenuPrincipal(string rol)
        {
            InitializeComponent();
            rolUsuario = rol;
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
           
            this.CenterToScreen();

            // Quién entró y con qué permisos
            lblBienvenida.Text = $"Sistema NOVAS - Rol actual: {rolUsuario}";

            // Lógica de validación de roles
            if (rolUsuario == "Cliente")
            {
                // Si es cliente, deshabilitamos la gestión de inventario
                btnRegistrar.Enabled = false;
                btnEliminar.Enabled = false;

                //También los ocultamos visualmente
                btnRegistrar.Visible = false;
                btnEliminar.Visible = false;
            }
            // Si no, es admin por lo que tednra todo activo
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cierra  la aplicación
            Application.Exit();
        }

        // --- Aquí irán los eventos de los demás botones para abrir las otras pantallas SAMUEL LEER ESTO ---
        // private void btnRegistrar_Click(...) { ... }
    }
}
