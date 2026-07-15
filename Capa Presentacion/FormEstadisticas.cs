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
    public partial class FormEstadisticas : Form
    {
        private SistemaNovas miSistema;

        public FormEstadisticas(SistemaNovas sistemaPrincipal)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.miSistema = sistemaPrincipal;
        }

        private void FormEstadisticas_Load(object sender, EventArgs e)
        {
            List<Videojuego> lista = miSistema.ObtenerListaDeJuegos();

            if (lista.Count == 0 || lista == null)
            {
                MessageBox.Show("No hay videojuegos registrados para generar estadísticas.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Realizar cálculos aritméticos manuales sobre la lista extraída
            int unidadesUnicas = lista.Count;
            int stockTotal = 0;
            double valorTotalInventario = 0;
            Videojuego masCaro = lista[0];

            foreach (var juego in lista)
            {
                stockTotal += juego.Stock;
                valorTotalInventario += (juego.Precio * juego.Stock);

                if (juego.Precio > masCaro.Precio)
                {
                    masCaro = juego;
                }
            }

            // Asignar los datos calculados a la interfaz gráfica
            lblTotalJuegos.Text = $"Modelos de juegos únicos: {unidadesUnicas}";
            lblStockTotal.Text = $"Total de unidades en stock: {stockTotal}";
            lblValorInventario.Text = $"Valor total del inventario: ${valorTotalInventario:F2}";
            lblMasCaro.Text = $"Videojuego más costoso:\r\n{masCaro.Titulo} (${masCaro.Precio:F2})";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTituloVentana_Click(object sender, EventArgs e)
        {

        }
    }
}
