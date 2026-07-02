using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Datos;

namespace Capa_Presentacion
{
    public partial class FormMenuPrincipal : Form
    {
        private string rolUsuario;

        // INSTANCIA GLOBAL DE LA TABLA HASH: Aquí se guardará el inventario en memoria.
        // Capacidad inicial de ejemplo: 100 cubetas
        private TablaHash inventarioVideojuegos = new TablaHash(100);

        public FormMenuPrincipal(string rol)
        {
            InitializeComponent();
            rolUsuario = rol;
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            lblBienvenida.Text = $"Sistema NOVAS - Rol actual: {rolUsuario}";

            if (rolUsuario == "Cliente")
            {
                btnRegistrar.Enabled = false;
                btnEliminar.Enabled = false;
                btnRegistrar.Visible = false;
                btnEliminar.Visible = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Pasamos la instancia actual de inventarioVideojuegos al formulario de búsqueda
            using (FormBuscarVideojuego formBuscar = new FormBuscarVideojuego(inventarioVideojuegos))
            {
                formBuscar.ShowDialog();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Pasamos la instancia actual de inventarioVideojuegos al formulario de eliminación
            using (FormEliminarVideojuego formEliminar = new FormEliminarVideojuego(inventarioVideojuegos))
            {
                formEliminar.ShowDialog();
            }
        }
        private void btnEstadistic_Click(object sender, EventArgs e)
        {
            using (FormEstadisticas formEst = new FormEstadisticas(inventarioVideojuegos))
            {
                formEst.ShowDialog();
            }
        }

        private void btnRanking_Click(object sender, EventArgs e)
        {
            using (FormRanking formRank = new FormRanking(inventarioVideojuegos))
            {
                formRank.ShowDialog();
            }
        }
        // EVENTO DEL BOTÓN REGISTRAR MODIFICADO
        private void btnRegistrar_click(object sender, EventArgs e)
        {
            // 1. Abrimos el formulario de registro como ventana de diálogo modal
            using (FormRegistrarVideojuego formRegistro = new FormRegistrarVideojuego())
            {
                // Si el usuario da clic en el botón Guardar y todo es válido
                if (formRegistro.ShowDialog() == DialogResult.OK)
                {
                    Videojuego nuevoJuego = formRegistro.VideojuegoCreado;

                    // 2. Verificar en la Tabla Hash si ya existe el ID antes de insertar
                    if (inventarioVideojuegos.Buscar(nuevoJuego.Id) != null)
                    {
                        MessageBox.Show($"El videojuego con ID '{nuevoJuego.Id}' ya existe en el inventario.",
                                        "ID Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // 3. Insertar en tu estructura de datos Tabla Hash
                        inventarioVideojuegos.Insertar(nuevoJuego);

                        MessageBox.Show($"¡El videojuego '{nuevoJuego.Titulo}' ha sido registrado exitosamente en el inventario!",
                                        "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {

        }
    }
}