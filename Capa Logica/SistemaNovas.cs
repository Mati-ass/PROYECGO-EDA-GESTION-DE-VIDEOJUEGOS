using System;
using System.Collections.Generic;
using Capa_Datos;

namespace Capa_Logica
{
    public class SistemaNovas
    {
        // Instancia de nuestra estructura de datos principal
        private TablaHash inventario;
        private List<Usuario> usuariosRegistrados;
        // Categorías estrictas permitidas (RF3)
        private readonly List<string> categoriasValidas = new List<string>
        {
            "RPG",
            "Shooter",
            "Deportes",
            "Metroidvania",
            "Otros"
        };

        public SistemaNovas()
        {
            inventario = new TablaHash(100);

            // Usuarios predeterminados ("quemados" en memoria para el prototipo)
            usuariosRegistrados = new List<Usuario>
    {
            new Usuario("admin", "admin123", "Administrador"),
            new Usuario("cliente1", "jugador2026", "Cliente")
    };
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
        public string ProcesarAltaVideojuego(string id, string titulo, string plataforma, string categoria, double precio, int stock)
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
            Videojuego nuevoJuego = new Videojuego(id, titulo, plataforma, categoria, stock, precio);

            inventario.Insertar(nuevoJuego);
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

            return $"Éxito: Stock actualizado. El nuevo stock de '{buscado.Titulo}' es {buscado.Stock}.";
        }
    }
}
