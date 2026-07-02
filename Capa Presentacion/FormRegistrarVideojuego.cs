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
    public partial class FormRegistrarVideojuego : Form
    {
        // Propiedad pública para que el menú principal pueda obtener el juego creado
        public Videojuego VideojuegoCreado { get; private set; }

        public FormRegistrarVideojuego()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // 1. Validaciones básicas de campos vacíos
            if (string.IsNullOrWhiteSpace(txtId.Text) || string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                MessageBox.Show("Por favor, llena los campos obligatorios (ID y Título).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. Parsear los datos numéricos de forma segura
                string id = txtId.Text.Trim();
                string titulo = txtTitulo.Text.Trim();
                string plataforma = txtPlataforma.Text.Trim();
                string categoria = txtCategoria.Text.Trim();
                int stock = int.Parse(txtStock.Text.Trim());
                double precio = double.Parse(txtPrecio.Text.Trim());

                // 3. Instanciar el objeto Videojuego
                VideojuegoCreado = new Videojuego(id, titulo, plataforma, categoria, stock, precio);

                // 4. Cerrar el formulario indicando éxito
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Asegúrate de que el Stock y el Precio sean números válidos.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
