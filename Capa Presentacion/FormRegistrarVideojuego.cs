using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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

        private string rutaImagenSeleccionada = "";
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
                VideojuegoCreado = new Videojuego(id, titulo, plataforma, categoria, stock, precio,rutaImagenSeleccionada);

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

        private void FormRegistrarVideojuego_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png";
                dialog.Title = "Seleccionar carátula del videojuego";

                if (dialog.ShowDialog() == DialogResult.OK)
                {

                    try
                    {
                        string carpetaDestino = Path.Combine(Application.StartupPath, "Imagenes");

                        if (!Directory.Exists(carpetaDestino))
                        {
                            Directory.CreateDirectory(carpetaDestino);
                        }

                        string nombreArchivo = Path.GetFileName(dialog.FileName);
                        string rutaCompletaDestino = Path.Combine(carpetaDestino, nombreArchivo);
                        

                        File.Copy(dialog.FileName, rutaCompletaDestino, true);

                        rutaImagenSeleccionada = nombreArchivo;
                        pbCaratula.ImageLocation = rutaCompletaDestino;
                        pbCaratula.SizeMode = PictureBoxSizeMode.Zoom;
                        MessageBox.Show("Imagen cargada y copiada al proyecto con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hubo un error al copiar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
