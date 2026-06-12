using System;

namespace Capa_Datos
{
    public class Nodo
    {
        public Videojuego Dato { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(Videojuego dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }
}
