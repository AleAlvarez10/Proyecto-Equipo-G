using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Equipo_G
{
    public partial class FrmLogin : Form
    {
        public string? idCliente { get; set; }  // Variable pública para el ID del cliente
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            GIF();
        }

        private void GIF()
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\elgra\Downloads\mario.gif");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txt_user.Text;   // ID del cliente

            try
            {
                // Conexión a la base de datos
                using (SqlConnection conexion = new SqlConnection("Server=LAPTOP-F9DVQSMH;Database=TiendaVideojuegos;Trusted_Connection=True;TrustServerCertificate=True;"))
                {
                    conexion.Open();

                    // Consulta SQL para verificar si el id_cliente existe
                    string query = "SELECT id_cliente FROM Clientes WHERE id_cliente = @usuario";
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);

                        object resultado = cmd.ExecuteScalar(); // Ejecutar consulta y obtener el id_cliente

                        if (resultado != null) // Cliente encontrado
                        {
                            int id_cliente = Convert.ToInt32(resultado);

                            // Asignar el ID del cliente a UsuarioActual
                            FrmMenuPr.UsuarioActual = id_cliente;

                            MessageBox.Show("¡Inicio de sesión exitoso!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Abrir el formulario principal (FrmMenuPr)
                            FrmMenuPr menu = new FrmMenuPr();
                            this.Hide(); // Ocultar formulario de login
                            menu.Show();
                        }
                        else
                        {
                            MessageBox.Show("El ID de cliente no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar sesión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegistrarse registro = new FrmRegistrarse();
            registro.Show();
        }
    }
}
