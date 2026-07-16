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
    public partial class FormRanking : Form
    {
        private SistemaNovas miSistema;

        // Guardamos los juegos que se están mostrando actualmente en el Top para saber cuál seleccionar
        private List<Videojuego> juegosMostrados = new List<Videojuego>();

        public FormRanking(SistemaNovas sistemaPrincipal)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.miSistema = sistemaPrincipal;

            // CORRECCIÓN: Usamos Click y KeyUp para detectar cuándo el usuario interactúa con el TextBox
            txtRanking.Click += (sender, e) => ActualizarImagenSeleccionada();
            txtRanking.KeyUp += (sender, e) => ActualizarImagenSeleccionada();
        }

        private void btnTopPrecio_Click(object sender, EventArgs e)
        {
            List<Videojuego> lista = miSistema.ObtenerListaDeJuegos();
            if (lista == null || lista.Count == 0)
            {
                txtRanking.Text = "No hay datos.";
                pbCaratulaRanking.Image = null;
                juegosMostrados.Clear(); // Limpiamos memoria
                return;
            }

            // Método clásico de ordenamiento Burbuja Descendente (por precio)
            for (int i = 0; i < lista.Count - 1; i++)
            {
                for (int j = 0; j < lista.Count - i - 1; j++)
                {
                    if (lista[j].Precio < lista[j + 1].Precio)
                    {
                        Videojuego temp = lista[j];
                        lista[j] = lista[j + 1];
                        lista[j + 1] = temp;
                    }
                }
            }

            MostrarEnPantalla(lista, "PRECIO", "Precio: $");
        }

        private void btnTopStock_Click(object sender, EventArgs e)
        {
            List<Videojuego> lista = miSistema.ObtenerListaDeJuegos();
            if (lista == null || lista.Count == 0)
            {
                txtRanking.Text = "No hay datos.";
                pbCaratulaRanking.Image = null;
                juegosMostrados.Clear(); // Limpiamos memoria
                return;
            }

            // Método Burbuja Descendente (por stock)
            for (int i = 0; i < lista.Count - 1; i++)
            {
                for (int j = 0; j < lista.Count - i - 1; j++)
                {
                    if (lista[j].Stock < lista[j + 1].Stock)
                    {
                        Videojuego temp = lista[j];
                        lista[j] = lista[j + 1];
                        lista[j + 1] = temp;
                    }
                }
            }

            MostrarEnPantalla(lista, "STOCK", "Unidades: ");
        }

        private void MostrarEnPantalla(List<Videojuego> listaOrdenada, string tipo, string prefijoUnidad)
        {
            txtRanking.Clear();
            juegosMostrados.Clear(); // Limpiamos el top anterior
            pbCaratulaRanking.Image = null; // Reiniciamos la imagen lateral

            txtRanking.AppendText($"--- TOP 5 VIDEOJUEGOS POR {tipo} ---\r\n\r\n");
            txtRanking.AppendText("(Haz clic en una línea para ver su carátula)\r\n\r\n");

            // Tomamos máximo 5 elementos y los guardamos en memoria
            int tope = Math.Min(5, listaOrdenada.Count);
            for (int i = 0; i < tope; i++)
            {
                var juego = listaOrdenada[i];
                juegosMostrados.Add(juego); // Lo recordamos para el click

                string valorStr = tipo == "PRECIO" ? juego.Precio.ToString("F2") : juego.Stock.ToString();
                txtRanking.AppendText($"{i + 1}. {juego.Titulo} ({prefijoUnidad}{valorStr})\r\n");
            }

            // Por defecto, intentamos mostrar la imagen del puesto #1
            if (juegosMostrados.Count > 0)
            {
                CargarImagenJuego(juegosMostrados[0]);
            }
        }

        // CORRECCIÓN: Método limpio que se ejecuta tanto al hacer click como al usar el teclado
        private void ActualizarImagenSeleccionada()
        {
            if (juegosMostrados.Count == 0) return;

            // Conseguimos el índice de la línea actual donde está el cursor del usuario
            int indiceLinea = txtRanking.GetLineFromCharIndex(txtRanking.SelectionStart);

            // Las primeras 4 líneas son encabezados (Título, instrucciones, línea vacía, etc.)
            int indiceJuego = indiceLinea - 4;

            if (indiceJuego >= 0 && indiceJuego < juegosMostrados.Count)
            {
                CargarImagenJuego(juegosMostrados[indiceJuego]);
            }
        }

        // Método auxiliar centralizado para cargar la imagen físicamente en el PictureBox
        private void CargarImagenJuego(Videojuego juego)
        {
            try
            {
                if (juego != null && !string.IsNullOrEmpty(juego.RutaImagen))
                {
                    string carpetaImagenes = Path.Combine(Application.StartupPath, "Imagenes");
                    string rutaCompleta = Path.Combine(carpetaImagenes, juego.RutaImagen);

                    if (File.Exists(rutaCompleta))
                    {
                        pbCaratulaRanking.SizeMode = PictureBoxSizeMode.Zoom;
                        pbCaratulaRanking.ImageLocation = rutaCompleta;
                        return;
                    }
                }
                pbCaratulaRanking.Image = null; // Si no hay imagen, limpiamos
            }
            catch
            {
                pbCaratulaRanking.Image = null;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}