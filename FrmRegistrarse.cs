using Proyecto_Equipo_G.Clases;
using ProyectoFinal_TBD_EquipoG.Clases;
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
    public partial class FrmRegistrarse : Form
    {
        public FrmRegistrarse()
        {
            InitializeComponent();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            // Crear un objeto de tipo Clientes
            Clientes cliente = new Clientes();
            cliente.nombre_cliente = txt_nombre.Text;
            cliente.correo = txt_correo.Text;
            cliente.telefono = txt_telefono.Text;

            // Llamar al método AgregarClientes y obtener el ID del cliente recién agregado
            int idCliente = ClientesDAL.AgregarClientes(cliente);

            if (idCliente > 0)
            {
                MessageBox.Show($"¡Registro Exitoso! Su User Asingado es: {idCliente}");
            }
            else
            {
                MessageBox.Show("Error al agregar el cliente.");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Pedir el ID del cliente mediante un MessageBox
            string input = Microsoft.VisualBasic.Interaction.InputBox("Ingrese su ID:", "Eliminar Cliente", "");

            if (int.TryParse(input, out int id_cliente))
            {
                // Confirmar si el usuario está seguro de eliminar al cliente
                DialogResult confirmacion = MessageBox.Show("¿Está seguro de que desea eliminar su cuenta :(?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    // Llamar al método EliminarCliente para eliminar al cliente
                    bool resultado = ClientesDAL.EliminarCliente(id_cliente);

                    if (resultado)
                    {
                        MessageBox.Show("¡Cliente eliminado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Eliminación cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("ID de cliente inválido. Por favor, ingrese un ID numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
