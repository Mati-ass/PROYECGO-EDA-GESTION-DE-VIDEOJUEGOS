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
                txtResultado.Text = $"ID: {juegoEncontrado.Id}\r\n" +
                                    $"Título: {juegoEncontrado.Titulo}\r\n" +
                                    $"Plataforma: {juegoEncontrado.Plataforma}\r\n" +
                                    $"Categoría: {juegoEncontrado.Categoria}\r\n" +
                                    $"Stock: {juegoEncontrado.Stock}\r\n" +
                                    $"Precio: ${juegoEncontrado.Precio:F2}\r\n" +
                                    $"Ventas: {juegoEncontrado.Ventas}\r\n" +
                                    $"Horas Jugadas: {juegoEncontrado.HorasJugadas}";
            }
            else
            {
                txtResultado.Text = "El videojuego no existe en el inventario.";
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
