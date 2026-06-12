namespace Capa_Datos
{
    public class Videojuego
    {
        public string Id { get; set; }
        public string Titulo { get; set; }
        public string Plataforma { get; set; }
        public string Categoria { get; set; }
        public int Stock { get; set; }
        public int Ventas { get; set; }
        public int HorasJugadas { get; set; }

        public Videojuego(string id, string titulo, string plataforma, string categoria, int stockInicial)
        {
            Id = id;
            Titulo = titulo;
            Plataforma = plataforma;
            Categoria = categoria;
            Stock = stockInicial;
            Ventas = 0;
            HorasJugadas = 0;
        }

        public void ActualizarStock(int cant)
        {
            Stock += cant;
        }
    }
}
