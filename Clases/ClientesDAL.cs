using Microsoft.Data.SqlClient;
using ProyectoFinal_TBD_EquipoG.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Equipo_G.Clases
{
    internal class ClientesDAL
    {
        public static int AgregarClientes(Clientes cliente)
        {
            int idClienteGenerado = 0;

            using (SqlConnection conn = BD.obtenerConexion())
            {
                string query = "INSERT INTO Clientes (nombre_cliente, correo, telefono) " +
                               "VALUES (@nombre_cliente, @correo, @telefono); " +
                               "SELECT SCOPE_IDENTITY();";  // Obtiene el ID generado automáticamente

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@nombre_cliente", cliente.nombre_cliente);
                command.Parameters.AddWithValue("@correo", cliente.correo);
                command.Parameters.AddWithValue("@telefono", cliente.telefono);

                // Ejecutar la consulta y obtener el ID generado
                var result = command.ExecuteScalar();

                if (result != null)
                {
                    idClienteGenerado = Convert.ToInt32(result); // Obtener el ID asignado
                }
            }

            return idClienteGenerado; // Devuelve el ID generado
        }

        public static bool EliminarCliente(int id_cliente)
        {
            bool exito = false;

            using (SqlConnection conn = BD.obtenerConexion())
            {
                string query = "DELETE FROM Clientes WHERE id_cliente = @id_cliente";

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@id_cliente", id_cliente);

                int filasAfectadas = command.ExecuteNonQuery(); // Ejecutar la consulta de eliminación

                if (filasAfectadas > 0)
                {
                    exito = true; // Si se afectaron filas, la eliminación fue exitosa
                }
            }

            return exito;
        }



    }
}
