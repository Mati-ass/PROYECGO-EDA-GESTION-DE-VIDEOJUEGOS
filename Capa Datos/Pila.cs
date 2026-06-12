using System;

namespace Capa_Datos
{
    public class Pila
    {
        private Nodo cima; 
        private int tamanio; 

        public Pila() 
        {
            cima = null;
            tamanio = 0;
        }

        public void Apilar(Videojuego v) 
        {
            Nodo nuevo = new Nodo(v);
            nuevo.Siguiente = cima;
            cima = nuevo;
            tamanio++;
        }

        public Videojuego Desapilar()
        {
            if (EstaVacia()) return null;

            Videojuego valor = cima.Dato;
            cima = cima.Siguiente;
            tamanio--;
            return valor;
        }

        public Videojuego VerTope() 
        {
            if (EstaVacia()) return null;
            return cima.Dato;
        }

        public bool EstaVacia() 
        {
            return cima == null;
        }
    }
}
