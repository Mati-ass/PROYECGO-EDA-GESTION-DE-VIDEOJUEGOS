using System;
namespace Capa_Datos
{
    public class TablaHash
    {
        private ListaEnlazada[] tabla;
        private int capacidad;

        public TablaHash(int capacidad)
        {
            this.capacidad = capacidad;
            tabla = new ListaEnlazada[capacidad];
            for (int i = 0; i < capacidad; i++)
            {
                tabla[i] = new ListaEnlazada();
            }
        }

        public int FuncionHash(string id)
        {
            int hash = 0;
            foreach (char c in id)
            {
                hash += c;
            }
            return hash % capacidad;
        }

        public void Insertar(Videojuego j)
        {
            int indice = FuncionHash(j.Id);
         
            if (tabla[indice].Buscar(j.Id) == null) // Verificar si el juego ya existe en la lista enlazada
            {
                tabla[indice].InsertarFinal(j);
                Console.WriteLine($"Juego '{j.Titulo}' ingresado al inventario.");
            }
        }

        public Videojuego Buscar(string id)
        {
            int indice = FuncionHash(id);
            return tabla[indice].Buscar(id);
        }

        public void Eliminar(string id)
        {
            int indice = FuncionHash(id);
            if (tabla[indice].Eliminar(id))
            {
                Console.WriteLine($"Juego con ID {id} eliminado del inventario.");
            }
            else
            {
                Console.WriteLine("Juego no encontrado.");
            }
        }
    }
}
