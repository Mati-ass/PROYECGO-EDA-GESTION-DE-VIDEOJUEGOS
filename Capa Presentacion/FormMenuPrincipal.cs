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
using Capa_Logica;
namespace Capa_Presentacion
{
    public partial class FormMenuPrincipal : Form
    {
        private string rolUsuario;

        private SistemaNovas miSistema;
        public FormMenuPrincipal(string rol)
        {
            InitializeComponent();
            rolUsuario = rol;

            miSistema = new SistemaNovas();
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            lblBienvenida.Text = $"- {rolUsuario} -";

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
            using (FormBuscarVideojuego formBuscar = new FormBuscarVideojuego(miSistema))
            {
                formBuscar.ShowDialog();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Pasamos la instancia actual de inventarioVideojuegos al formulario de eliminación
            using (FormEliminarVideojuego formEliminar = new FormEliminarVideojuego(miSistema))
            {
                formEliminar.ShowDialog();
            }
        }
        private void btnEstadistic_Click(object sender, EventArgs e)
        {
            using (FormEstadisticas formEst = new FormEstadisticas(miSistema))
            {
                formEst.ShowDialog();
            }
        }

        private void btnRanking_Click(object sender, EventArgs e)
        {
            using (FormRanking formRank = new FormRanking(miSistema))
            {
                formRank.ShowDialog();
            }
        }
        private void btnRegistrar_click(object sender, EventArgs e)
        {
            // 1. Abrimos el formulario de registro
            using (FormRegistrarVideojuego formRegistro = new FormRegistrarVideojuego())
            {
                if (formRegistro.ShowDialog() == DialogResult.OK)
                {
                    // Obtenemos el objeto que tu formulario de registro creó
                    Videojuego nuevoJuego = formRegistro.VideojuegoCreado;

                    // 3. CAMBIO CLAVE: Usamos el método de la capa lógica para registrar y guardar en el JSON
                    string resultado = miSistema.ProcesarAltaVideojuego(
                        nuevoJuego.Id,
                        nuevoJuego.Titulo,
                        nuevoJuego.Plataforma,
                        nuevoJuego.Categoria,
                        nuevoJuego.Precio,
                        nuevoJuego.Stock,
                        nuevoJuego.RutaImagen // Asegúrate de que tu FormRegistrar capture la imagen
                    );

                    // Mostramos el resultado (Si es éxito, el método ProcesarAltaVideojuego ya actualizó el JSON)
                    if (resultado.StartsWith("Error"))
                    {
                        MessageBox.Show(resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(resultado, "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void btnBuscar_Click_1(object sender, EventArgs e)
        {

        }

        private void lblBienvenida_Click(object sender, EventArgs e)
        {

        }

        private void lblBienvenida_Click_1(object sender, EventArgs e)
        {

        }
    }
}