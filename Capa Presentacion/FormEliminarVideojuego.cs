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
    public partial class FormEliminarVideojuego : Form
    {
        private TablaHash inventario;

        public FormEliminarVideojuego(TablaHash tablaPrincipal)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.inventario = tablaPrincipal;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text.Trim();

            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Ingresa un ID.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar primero si existe antes de borrar
            Videojuego juego = inventario.Buscar(id);

            if (juego != null)
            {
                var confirmacion = MessageBox.Show($"¿Estás seguro de que deseas eliminar '{juego.Titulo}'?",
                    "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    // Llama a tu método Eliminar de TablaHash
                    inventario.Eliminar(id);
                    MessageBox.Show("Videojuego eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("No se encontró ningún videojuego con ese ID.", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}