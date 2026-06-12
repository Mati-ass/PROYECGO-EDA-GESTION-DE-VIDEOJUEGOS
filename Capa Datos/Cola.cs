using System;

namespace Capa_Datos
{
    public class Cola
    {
        private Nodo frente; 
        private Nodo final; 
        private int tamaño; 

        public Cola() 
        {
            frente = null;
            final = null;
            tamaño = 0;
        }

        public void Encolar(Videojuego v) 
        {
            Nodo nuevo = new Nodo(v);
            if (EstaVacia())
            {
                frente = nuevo;
                final = nuevo;
            }
            else
            {
                final.Siguiente = nuevo;
                final = nuevo;
            }
            tamaño++;
        }

        public Videojuego Desencolar() 
        {
            if (EstaVacia()) return null;

            Videojuego valor = frente.Dato;
            frente = frente.Siguiente;

            if (frente == null)
            {
                final = null;
            }

            tamaño--;
            return valor;
        }

        public bool EstaVacia() 
        {
            return frente == null;
        }
    }
}
