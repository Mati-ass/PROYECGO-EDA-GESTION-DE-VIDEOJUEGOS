using System;
using System.Windows.Forms;
using Capa_Datos; 
// using Capa_Logica; 

namespace Capa_Presentacion
{
    public partial class Login : Form
    {
 
        private Capa_Logica.SistemaNovas miSistema = new Capa_Logica.SistemaNovas();

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //Centrar la pantalla
            this.CenterToScreen();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string username = tbNameUser.Text;
            string password = tbPassword.Text;

            Usuario usuarioLogueado = miSistema.IniciarSesion(username, password);

            // Validamos datos!
            if (usuarioLogueado != null)
            {
                MessageBox.Show($"Bienvenido al sistema, {usuarioLogueado.Username}.",
                                "Acceso Concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Aquí abriremos el Menú Principal y le pasaremos el Rol (COMENTANTADO PQ AUN NO ESTÁ IMPLEMENTADO)
                FormMenuPrincipal menu = new FormMenuPrincipal(usuarioLogueado.Rol);
                menu.Show();
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.",
                                "Error de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);

             
                tbPassword.Clear();
                tbNameUser.Focus();
            }
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
    }
}