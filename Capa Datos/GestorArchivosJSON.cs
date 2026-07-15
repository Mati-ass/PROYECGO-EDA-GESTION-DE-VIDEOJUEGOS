using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Capa_Datos
{
    public class GestorArchivosJSON
    {
        private readonly string rutaArchivo = "inventario_novas.json";

        public void GuardarDatos(List<Videojuego> listaJuegos)
        {
            // Convertimos la lista de objetos a texto JSON
            var opciones = new JsonSerializerOptions { WriteIndented = true }; // Para que se vea ordenado
            string json = JsonSerializer.Serialize(listaJuegos, opciones);

            // Escribimos el texto en el archivo
            File.WriteAllText(rutaArchivo, json);
        }

        public List<Videojuego> CargarDatos()
        {
            
            if (!File.Exists(rutaArchivo))
            {
                return new List<Videojuego>();
            }

            // Leemos el texto y lo convertimos de vuelta a objetos Videojuego
            string json = File.ReadAllText(rutaArchivo);
            return JsonSerializer.Deserialize<List<Videojuego>>(json);
        }
    
    }
}
