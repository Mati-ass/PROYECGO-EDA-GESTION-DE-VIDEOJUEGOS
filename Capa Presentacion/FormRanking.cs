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
    public partial class FormRanking : Form
    {
        private SistemaNovas miSistema;

        public FormRanking(SistemaNovas sistemaPrincipal)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.miSistema = sistemaPrincipal;
        }

        private void btnTopPrecio_Click(object sender, EventArgs e)
        {
            List<Videojuego> lista = miSistema.ObtenerListaDeJuegos();
            if (lista.Count == 0 || lista == null) { txtRanking.Text = "No hay datos."; return; }

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
            if (lista.Count == 0) { txtRanking.Text = "No hay datos."; return; }

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
            txtRanking.AppendText($"--- TOP 5 VIDEOJUEGOS POR {tipo} ---\r\n\r\n");

            // Tomamos máximo 5 elementos
            int tope = Math.Min(5, listaOrdenada.Count);
            for (int i = 0; i < tope; i++)
            {
                var juego = listaOrdenada[i];
                string valorStr = tipo == "PRECIO" ? juego.Precio.ToString("F2") : juego.Stock.ToString();
                txtRanking.AppendText($"{i + 1}. {juego.Titulo} ({prefijoUnidad}{valorStr})\r\n");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
