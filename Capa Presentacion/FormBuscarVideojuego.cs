using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO; // Para Path y File
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Datos;
using Capa_Logica;

namespace Capa_Presentacion
{
    public partial class FormBuscarVideojuego : Form
    {
        private SistemaNovas miSistema;

        // Recibimos la tabla hash
        public FormBuscarVideojuego(SistemaNovas sistemaPrincipal)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.miSistema = sistemaPrincipal;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text.Trim();

            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Por favor, ingresa un ID válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Usamos el método Buscar de tu TablaHash
            Videojuego juegoEncontrado = miSistema.BuscarJuego(id);

            if (juegoEncontrado != null)
            {
                // 1. Mostrar los datos de texto en el TextBox de resultados
                txtResultado.Text = $"ID: {juegoEncontrado.Id}\r\n" +
                                    $"Título: {juegoEncontrado.Titulo}\r\n" +
                                    $"Plataforma: {juegoEncontrado.Plataforma}\r\n" +
                                    $"Categoría: {juegoEncontrado.Categoria}\r\n" +
                                    $"Stock: {juegoEncontrado.Stock}\r\n" +
                                    $"Precio: ${juegoEncontrado.Precio:F2}\r\n" +
                                    $"Ventas: {juegoEncontrado.Ventas}\r\n" +
                                    $"Horas Jugadas: {juegoEncontrado.HorasJugadas}";

                // 2. Mostrar la carátula en el PictureBox (pbCaratulaBuscar)
                // Usamos "try-catch" para prevenir cualquier error inesperado al leer el disco
                try
                {
                    if (!string.IsNullOrEmpty(juegoEncontrado.RutaImagen))
                    {
                        // Reconstruimos la ruta: carpeta de tu app + "Imagenes" + nombre de la imagen
                        string carpetaImagenes = Path.Combine(Application.StartupPath, "Imagenes");
                        string rutaCompleta = Path.Combine(carpetaImagenes, juegoEncontrado.RutaImagen);

                        if (File.Exists(rutaCompleta))
                        {
                            pbCaratulaBuscar.SizeMode = PictureBoxSizeMode.Zoom;
                            pbCaratulaBuscar.ImageLocation = rutaCompleta; // Carga la imagen de forma segura
                        }
                        else
                        {
                            // Si guardaste un nombre de archivo pero por alguna razón no está en la carpeta
                            pbCaratulaBuscar.Image = null;
                        }
                    }
                    else
                    {
                        // Si el juego se registró sin carátula
                        pbCaratulaBuscar.Image = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un inconveniente al cargar la imagen: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    pbCaratulaBuscar.Image = null;
                }
            }
            else
            {
                txtResultado.Text = "El videojuego no existe en el inventario.";
                pbCaratulaBuscar.Image = null; // Limpiamos la imagen si el juego no existe
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormBuscarVideojuego_Load(object sender, EventArgs e)
        {

        }
    }
}