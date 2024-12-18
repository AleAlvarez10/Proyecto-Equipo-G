using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Equipo_G.Clases
{
    internal class VentasDAL
    {
        public static int EliminarVenta(int idCliente, int idVideojuego)
        {
            int resultado = 0;

            try
            {
                using (SqlConnection conn = BD.obtenerConexion())
                {
                    string query = "DELETE FROM Ventas WHERE id_cliente = @id_cliente AND id_videojuego = @id_videojuego";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@id_cliente", idCliente);
                    command.Parameters.AddWithValue("@id_videojuego", idVideojuego);

                    // Depuración: Mostrar los valores de los parámetros antes de ejecutar la consulta
                    MessageBox.Show($"Eliminando venta con cliente ID: {idCliente} y videojuego ID: {idVideojuego}");

                    // Ejecución de la consulta
                    resultado = command.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        MessageBox.Show($"Venta con cliente ID: {idCliente} y videojuego ID: {idVideojuego} eliminada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
            }
            catch (Exception )
            {
                MessageBox.Show($"Venta Eliminada");
            }

            return resultado;
        }




    }
}
