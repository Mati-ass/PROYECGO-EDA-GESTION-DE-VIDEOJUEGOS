using System;
using System.Collections.Generic;
using Capa_Datos;

namespace Capa_Logica
{
    public class SistemaNovas
    {
        private TablaHash inventario;
        private List<Usuario> usuariosRegistrados;
        private GestorArchivosJSON gestorArchivos;
        // Categorías estrictas

        private readonly List<string> categoriasValidas = new List<string>
        {
            "RPG",
            "Shooter",
            "Deportes",
            "Metroidvania",
            "Otros",
            "MOBA"
        };

        public SistemaNovas()
        {
            inventario = new TablaHash(100);
            gestorArchivos = new GestorArchivosJSON();

            // predeterminados
            usuariosRegistrados = new List<Usuario>
            {
                new Usuario("admin", "admin123", "Administrador"),
                new Usuario("cliente", "cliente67", "Cliente")
            };
            CargarInventarioDesdeArchivo();
        }

        // Método de validación de Login
        public Usuario IniciarSesion(string username, string password)
        {
            foreach (var user in usuariosRegistrados)
            {
                if (user.Username == username && user.Password == password)
                {
                    return user; // Login exitoso, devolvemos el objeto usuario
                }
            }
            return null; // Credenciales incorrectas
        }

        //  MÓDULO CRUD
        public string ProcesarAltaVideojuego(string id, string titulo, string plataforma, string categoria, double precio, int stock, string rutaImagen)
        {
            // 1. Validar campos vacíos (modificar para el forms)
            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(titulo) || string.IsNullOrWhiteSpace(plataforma))
            {
                return "Error: ID, Título y Plataforma son campos obligatorios.";
            }

            // 2. Validación de precios y stock (básica pero esencial)
            if (precio <= 0) return "Error: El precio debe ser un valor positivo.";
            if (stock < 0) return "Error: El stock inicial no puede ser negativo.";

            // 3. Categorización estricta (RF3)
            if (!categoriasValidas.Contains(categoria))
            {
                return $"Error: La categoría '{categoria}' no es válida. Seleccione una de la lista permitida.";
            }

            // 4. Evitar duplicados en la Tabla Hash
            if (inventario.Buscar(id) != null)
            {
                return "Error: Ya existe un videojuego registrado con ese código ID.";
            }

            // 5. Creamos el videojuego y lo insertamos en la estructura
            Videojuego nuevoJuego = new Videojuego(id, titulo, plataforma, categoria, stock, precio, rutaImagen);

            inventario.Insertar(nuevoJuego);

            SincronizarArchivo();
            return $"Éxito: '{titulo}' registrado correctamente en el inventario.";
        }

        // --- Bajas ---
        public string EliminarVideojuego(string id)
        {
            if (string.IsNullOrWhiteSpace(id)) return "Error: Ingrese un ID válido para eliminar.";

            Videojuego buscado = inventario.Buscar(id);
            if (buscado == null)
            {
                return "Error: El videojuego no existe en el sistema.";
            }

            inventario.Eliminar(id);
            SincronizarArchivo();
            return $"Éxito: El juego '{buscado.Titulo}' ha sido dado de baja permanentemente.";
        }

        // --- Búsqueda ---
        public Videojuego BuscarJuego(string id)
        {
            return inventario.Buscar(id);
        }

        // ---Actualizaciones de Stock ---
        public string ActualizarStockJuego(string id, int cantidadAgregada)
        {
            if (string.IsNullOrWhiteSpace(id)) return "Error: ID inválido.";

            Videojuego buscado = inventario.Buscar(id);
            if (buscado == null)
            {
                return "Error: El videojuego no existe en el inventario.";
            }

            buscado.ActualizarStock(cantidadAgregada);
            SincronizarArchivo();
            return $"Éxito: Stock actualizado. El nuevo stock de '{buscado.Titulo}' es {buscado.Stock}.";
        }


        private void SincronizarArchivo()
        {
          
            List<Videojuego> listaActual = inventario.ObtenerTodos();
            gestorArchivos.GuardarDatos(listaActual);
        }

        private void CargarInventarioDesdeArchivo()
        {
            List<Videojuego> juegosGuardados = gestorArchivos.CargarDatos();
            foreach (var juego in juegosGuardados)
            {
                inventario.Insertar(juego); 
            }
        }

        public List<Videojuego> ObtenerListaDeJuegos()
        {
            return inventario.ObtenerTodos();
        }
    }
}
