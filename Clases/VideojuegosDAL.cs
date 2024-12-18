using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace ProyectoFinal_TBD_EquipoG.Clases
{
    internal class VideojuegosDAL
    {
        public static List<Videojuegos> Mostrar()
        {
            List<Videojuegos> lista = new List<Videojuegos>();

            using (SqlConnection conn = BD.obtenerConexion())  // Asegúrate de que BD esté usando Microsoft.Data.SqlClient también
            {
                string query = "SELECT * FROM Videojuegos";
                SqlCommand command = new SqlCommand(query, conn);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Videojuegos videojuego = new Videojuegos();

                    videojuego.id_videojuego = reader.IsDBNull(0) ? null : reader.GetInt32(0);
                    videojuego.titulo = reader.IsDBNull(1) ? null : reader.GetString(1);
                    videojuego.id_genero = reader.IsDBNull(2) ? null : reader.GetInt32(2);
                    videojuego.id_desarrollador = reader.IsDBNull(3) ? null : reader.GetInt32(3);
                    videojuego.precio = reader.IsDBNull(4) ? null : reader.GetDecimal(4);
                    videojuego.plataforma = reader.IsDBNull(5) ? null : reader.GetString(5);
                    videojuego.stock = reader.IsDBNull(6) ? null : reader.GetInt32(6);
                    videojuego.descripcion = reader.IsDBNull(7) ? null : reader.GetString(7);

                    lista.Add(videojuego);
                }

                conn.Close();
                return lista;
            }
        }

        public static List<(string titulo, int total_vendido)> ObtenerJuegosMasVendidos()
        {
            // Lista de resultados: título del videojuego y la cantidad vendida
            List<(string titulo, int total_vendido)> lista = new List<(string, int)>();

            using (SqlConnection conn = BD.obtenerConexion()) // Asegúrate de que BD.obtenerConexion devuelve una conexión válida
            {
                // Consulta SQL para obtener los juegos más vendidos
                string query = @"
                SELECT V.titulo, SUM(VS.cantidad) AS total_vendido
                FROM Videojuegos V
                INNER JOIN Ventas VS ON V.id_videojuego = VS.id_videojuego
                GROUP BY V.titulo
                ORDER BY total_vendido DESC;";

                SqlCommand command = new SqlCommand(query, conn);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // Leer los valores del resultado
                    string titulo = reader.IsDBNull(0) ? string.Empty : reader.GetString(0);
                    int totalVendido = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);

                    // Añadir a la lista el resultado como tupla
                    lista.Add((titulo, totalVendido));
                }

                conn.Close();
                return lista;
            }
        }

                
            public static List<(int id_cliente, string nombre_cliente, int total_juegos, decimal monto_total)> ObtenerMejoresClientes()
            {
                // Lista para almacenar los resultados
                List<(int id_cliente, string nombre_cliente, int total_juegos, decimal monto_total)> lista =
                    new List<(int, string, int, decimal)>();

                using (SqlConnection conn = BD.obtenerConexion()) // Asegúrate de que BD.obtenerConexion devuelve una conexión válida
                {
                    // Consulta SQL
                    string query = @"
                SELECT C.id_cliente, C.nombre_cliente, 
                       SUM(V.cantidad) AS total_juegos_comprados, 
                       SUM(V.monto_total) AS monto_total_comprado
                FROM Clientes C
                INNER JOIN Ventas V ON C.id_cliente = V.id_cliente
                GROUP BY C.id_cliente, C.nombre_cliente
                ORDER BY monto_total_comprado DESC;";

                    SqlCommand command = new SqlCommand(query, conn);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int id_cliente = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                        string nombre_cliente = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                        int total_juegos = reader.IsDBNull(2) ? 0 : reader.GetInt32(2);
                        decimal monto_total = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3);

                        // Añadir a la lista
                        lista.Add((id_cliente, nombre_cliente, total_juegos, monto_total));
                    }

                    conn.Close();
                    return lista;
                }
            }

        public static List<(string genero, int totalUnidades, decimal montoTotal)> ObtenerVentasPorGenero()
        {
            // Lista para almacenar los resultados
            List<(string genero, int totalUnidades, decimal montoTotal)> lista = new List<(string, int, decimal)>();

            using (SqlConnection conn = BD.obtenerConexion()) // Reemplaza BD.obtenerConexion() con tu método de conexión
            {
                string query = @"
                SELECT g.nombre_genero, 
                       SUM(v.cantidad) AS TotalUnidadesVendidas, 
                       SUM(v.cantidad * vi.precio) AS MontoTotalGenerado
                FROM Ventas v
                INNER JOIN Videojuegos vi ON v.id_videojuego = vi.id_videojuego
                INNER JOIN Generos g ON vi.id_genero = g.id_genero
                GROUP BY g.nombre_genero
                ORDER BY MontoTotalGenerado DESC";

                SqlCommand command = new SqlCommand(query, conn);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string genero = reader.GetString(0);
                    int totalUnidades = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
                    decimal montoTotal = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2);

                    lista.Add((genero, totalUnidades, montoTotal));
                }

                conn.Close();
            }

            return lista;
        }

        public static List<(string desarrollador, decimal montoTotal)> ObtenerVentasPorDesarrollador()
        {
            // Lista para almacenar los resultados
            List<(string desarrollador, decimal montoTotal)> lista = new List<(string, decimal)>();

            using (SqlConnection conn = BD.obtenerConexion()) // Método de conexión
            {
                string query = @"
                SELECT d.nombre_desarrollador, 
                       SUM(v.cantidad * vi.precio) AS MontoTotalGenerado
                FROM Ventas v
                INNER JOIN Videojuegos vi ON v.id_videojuego = vi.id_videojuego
                INNER JOIN Desarrolladores d ON vi.id_desarrollador = d.id_desarrollador
                GROUP BY d.nombre_desarrollador
                ORDER BY MontoTotalGenerado DESC";

                SqlCommand command = new SqlCommand(query, conn);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string desarrollador = reader.GetString(0);
                    decimal montoTotal = reader.IsDBNull(1) ? 0 : reader.GetDecimal(1);

                    lista.Add((desarrollador, montoTotal));
                }

                conn.Close();
            }

            return lista;
        }

        public static bool AgregarVideojuego(Videojuegos videojuego)
        {
            bool exito = false;

            using (SqlConnection conn = BD.obtenerConexion())
            {
                // Definimos la consulta para insertar un videojuego en la tabla
                string query = "INSERT INTO Videojuegos (titulo, id_genero, id_desarrollador, precio, plataforma, stock, descripcion) " +
                               "VALUES (@titulo, @id_genero, @id_desarrollador, @precio, @plataforma, @stock, @descripcion)";

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@titulo", videojuego.titulo);
                command.Parameters.AddWithValue("@id_genero", videojuego.id_genero);
                command.Parameters.AddWithValue("@id_desarrollador", videojuego.id_desarrollador);
                command.Parameters.AddWithValue("@precio", videojuego.precio);
                command.Parameters.AddWithValue("@plataforma", videojuego.plataforma);
                command.Parameters.AddWithValue("@stock", videojuego.stock);
                command.Parameters.AddWithValue("@descripcion", videojuego.descripcion);

                int filasAfectadas = command.ExecuteNonQuery(); // Ejecutamos la consulta para insertar el videojuego

                if (filasAfectadas > 0)
                {
                    exito = true; // Si se afectaron filas, la inserción fue exitosa
                }
            }

            return exito;
        }


    }




}

