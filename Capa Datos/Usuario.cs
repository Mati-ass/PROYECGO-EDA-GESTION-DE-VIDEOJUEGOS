using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class Usuario
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Rol { get; set; } // "Administrador" o "Cliente"

        public Usuario(string username, string password, string rol)
        {
            Username = username;
            Password = password;
            Rol = rol;
        }
    }
}