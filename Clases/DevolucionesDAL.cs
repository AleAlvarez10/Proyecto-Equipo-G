using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Equipo_G.Clases
{
    internal class DevolucionesDAL
    {
        public static int AgregarDevolucion(Devoluciones devolucion)
        {
            int resultado = 0;

            using (SqlConnection conn = BD.obtenerConexion())
            {
                // Iniciar una transacción para asegurar que ambos procesos (insertar en devoluciones y eliminar en ventas) sean atómicos.
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Primero insertamos en la tabla de Devoluciones
                    string queryDevolucion = "INSERT INTO Devoluciones (fecha_devolucion, id_cliente, id_videojuego, cantidad, motivo) " +
                                             "VALUES (@fecha_devolucion, @id_cliente, @id_videojuego, @cantidad, @motivo)";
                    SqlCommand cmdDevolucion = new SqlCommand(queryDevolucion, conn, transaction);
                    cmdDevolucion.Parameters.AddWithValue("@fecha_devolucion", devolucion.fecha_devolucion);
                    cmdDevolucion.Parameters.AddWithValue("@id_cliente", devolucion.id_cliente);
                    cmdDevolucion.Parameters.AddWithValue("@id_videojuego", devolucion.id_videojuego);
                    cmdDevolucion.Parameters.AddWithValue("@cantidad", devolucion.cantidad);
                    cmdDevolucion.Parameters.AddWithValue("@motivo", devolucion.motivo);

                    // Ejecutamos la inserción de la devolución
                    resultado = cmdDevolucion.ExecuteNonQuery();

                    // Si la inserción de la devolución fue exitosa, procedemos a eliminar la venta correspondiente
                    if (resultado > 0)
                    {
                        string queryEliminarVenta = "DELETE FROM Ventas WHERE id_cliente = @id_cliente AND id_videojuego = @id_videojuego";
                        SqlCommand cmdVenta = new SqlCommand(queryEliminarVenta, conn, transaction);
                        cmdVenta.Parameters.AddWithValue("@id_cliente", devolucion.id_cliente);
                        cmdVenta.Parameters.AddWithValue("@id_videojuego", devolucion.id_videojuego);

                        // Ejecutamos la eliminación de la venta
                        cmdVenta.ExecuteNonQuery();
                    }

                    // Si todo ha ido bien, commit de la transacción
                    transaction.Commit();
                }
                catch (Exception)
                {
                    // Si algo falla, hacemos rollback de la transacción
                    transaction.Rollback();
                    resultado = 0;
                }
            }
            return resultado;
        }

    }
}
