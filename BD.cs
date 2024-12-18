using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Data;
using Microsoft.Data.SqlClient;

    public class BD
    {

    string cadenaConexion = "Server=LAPTOP-F9DVQSMH;Database=TiendaVideojuegos;Trusted_Connection=True;TrustServerCertificate=True;";
    SqlConnection conexion;
        
        private SqlConnection abrirConexion()
        {
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();

                return conexion;

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return null;
            }


        }

        private void cerrarConexion()
        {
            try
            {
                if (conexion != null)
                {
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

    public static SqlConnection obtenerConexion()
    {
        SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=TiendaVideojuegos;Data Source=LAPTOP-F9DVQSMH;TrustServerCertificate=True");
        conn.Open();

        return conn;
    }

}

