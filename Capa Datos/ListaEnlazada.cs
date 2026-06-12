using System;
namespace Capa_Datos
{
    public class ListaEnlazada
    {
        private Nodo cabeza;
        private int longitud;

        public ListaEnlazada()
        {
            cabeza = null;
            longitud = 0;
        }

        public void InsertarFinal(Videojuego v)
        {
            Nodo nuevo = new Nodo(v);
            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                Nodo actual = cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevo;
            }
            longitud++;
        }

        public bool Eliminar(string id)
        {
            if (cabeza == null) return false;

            if (cabeza.Dato.Id == id)
            {
                cabeza = cabeza.Siguiente;
                longitud--;
                return true;
            }

            Nodo actual = cabeza;
            while (actual.Siguiente != null && actual.Siguiente.Dato.Id != id)
            {
                actual = actual.Siguiente;
            }

            if (actual.Siguiente != null)
            {
                actual.Siguiente = actual.Siguiente.Siguiente;
                longitud--;
                return true;
            }
            return false;
        }

        public Videojuego Buscar(string id)
        {
            Nodo actual = cabeza;
            while (actual != null)
            {
                if (actual.Dato.Id == id)
                    return actual.Dato;
                actual = actual.Siguiente;
            }
            return null;
        }
    }
}
