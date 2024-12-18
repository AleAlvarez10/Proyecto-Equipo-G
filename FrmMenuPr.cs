using Microsoft.Data.SqlClient;
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
    public partial class FrmMenuPr : Form
    {
        public static int UsuarioActual { get; set; } // ID del cliente activo
        int id_videojuego;
        int cantidad;
        decimal monto_total;

        public FrmMenuPr()
        {
            InitializeComponent();

        }

        private void FrmMenuPr_Load(object sender, EventArgs e)
        {
            dgvCatalogo.DataSource = VideojuegosDAL.Mostrar();

            dgvCarrito.Columns.Add("id_videojuego", "ID Videojuego");
            dgvCarrito.Columns.Add("titulo", "Título");
            dgvCarrito.Columns.Add("precio", "Precio");
            dgvCarrito.Columns.Add("cantidad", "Cantidad");
            dgvCarrito.Columns.Add("monto_total", "Monto Total");

            int LabelID = FrmMenuPr.UsuarioActual;

            labelID.Text = ("ID Cliente: " + LabelID);


        }

        private void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            String Cupon = txt_cupon.Text;
            decimal precio;
            // Verifica si hay una fila seleccionada
            if (dgvCatalogo.CurrentRow != null)
            {
                // Captura los datos del videojuego seleccionado
                int id_videojuego = Convert.ToInt32(dgvCatalogo.CurrentRow.Cells["id_videojuego"].Value);
                string titulo = dgvCatalogo.CurrentRow.Cells["titulo"].Value.ToString();


                if (Cupon == "1COMPRA")
                {
                    precio = Convert.ToDecimal(dgvCatalogo.CurrentRow.Cells["precio"].Value) * 0.90m;

                }
                else if (Cupon == "FELIZCUMPLE")
                {
                    precio = Convert.ToDecimal(dgvCatalogo.CurrentRow.Cells["precio"].Value) * 0.75m;
                }
                else if (Cupon == "BUENFIN")
                {
                    precio = Convert.ToDecimal(dgvCatalogo.CurrentRow.Cells["precio"].Value) * 0.65m;
                }
                else
                {
                    precio = Convert.ToDecimal(dgvCatalogo.CurrentRow.Cells["precio"].Value);
                }
                int stock = Convert.ToInt32(dgvCatalogo.CurrentRow.Cells["stock"].Value);

                // Pide al usuario la cantidad deseada
                string inputCantidad = Microsoft.VisualBasic.Interaction.InputBox(
                    "Ingrese la cantidad que desea comprar:", "Cantidad", "1");

                // Valida la cantidad ingresada
                if (int.TryParse(inputCantidad, out int cantidad) && cantidad > 0 && cantidad <= stock)
                {
                    // Resta la cantidad del stock en el catálogo
                    dgvCatalogo.CurrentRow.Cells["stock"].Value = stock - cantidad;

                    // Agrega el videojuego al carrito (DataGridView de la derecha)
                    dgvCarrito.Rows.Add(id_videojuego, titulo, precio, cantidad, precio * cantidad);
                }
                else
                {
                    MessageBox.Show("Cantidad inválida o insuficiente stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un videojuego del catálogo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            // Obtener el ID del cliente desde UsuarioActual
            int id_cliente = FrmMenuPr.UsuarioActual;

            // Obtener el cupon ingresado
            String Cupon = txt_cupon.Text;

            // Verificar si el cliente ha iniciado sesión
            if (id_cliente <= 0)
            {
                MessageBox.Show("ID de cliente inválido. Debe iniciar sesión.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal monto_total = 0; // Inicializamos el monto total

            // Recorrer el carrito y calcular el monto total por cada producto
            foreach (DataGridViewRow row in dgvCarrito.Rows)
            {
                if (row.Cells["id_videojuego"].Value != null)
                {
                    int id_videojuego = Convert.ToInt32(row.Cells["id_videojuego"].Value);
                    int cantidad = Convert.ToInt32(row.Cells["cantidad"].Value);
                    decimal precio = Convert.ToDecimal(row.Cells["precio"].Value);

                    // Sumar al monto total con cada producto
                    decimal montoProducto = precio * cantidad;
                    monto_total += montoProducto; // Sumar al monto total general
                }
            }

            // Aplicar el descuento basado en el cupon ingresado
            decimal descuento = 0;
            if (Cupon == "1COMPRA")
            {
                descuento = monto_total * 0.10m;  // 10% de descuento
                decimal precio = monto_total - descuento;

                monto_total -= descuento;
                try
                {
                    using (SqlConnection conexion = new SqlConnection("Server=LAPTOP-F9DVQSMH;Database=TiendaVideojuegos;Trusted_Connection=True;TrustServerCertificate=True;"))
                    {
                        conexion.Open();

                        // Insertar cada producto del carrito en la base de datos
                        foreach (DataGridViewRow row in dgvCarrito.Rows)
                        {
                            if (row.Cells["id_videojuego"].Value != null)
                            {
                                int id_videojuego = Convert.ToInt32(row.Cells["id_videojuego"].Value);
                                int cantidad = Convert.ToInt32(row.Cells["cantidad"].Value);
                                precio = Convert.ToDecimal(row.Cells["precio"].Value);
                                decimal montoProducto = precio * cantidad;

                                // Insertar la venta de cada videojuego en la base de datos
                                string query = "INSERT INTO Ventas (fecha_venta, id_cliente, id_videojuego, cantidad, monto_total) " +
                                               "VALUES (@fecha_venta, @id_cliente, @id_videojuego, @cantidad, @monto_total)";

                                using (SqlCommand cmd = new SqlCommand(query, conexion))
                                {
                                    cmd.Parameters.AddWithValue("@fecha_venta", DateTime.Now);
                                    cmd.Parameters.AddWithValue("@id_cliente", id_cliente);
                                    cmd.Parameters.AddWithValue("@id_videojuego", id_videojuego);
                                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                                    cmd.Parameters.AddWithValue("@monto_total", montoProducto); // Usamos el monto individual para cada videojuego

                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }

                        // Mostrar mensaje de éxito
                        MessageBox.Show($"¡Compra finalizada exitosamente! Monto Total con descuento: {monto_total:C}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvCarrito.Rows.Clear();  // Limpiar el carrito
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al finalizar la compra: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (Cupon == "FELIZCUMPLE")
            {
                descuento = monto_total * 0.25m;  // 25% de descuento
                decimal precio = monto_total - descuento;

                monto_total -= descuento;
                try
                {
                    using (SqlConnection conexion = new SqlConnection("Server=LAPTOP-F9DVQSMH;Database=TiendaVideojuegos;Trusted_Connection=True;TrustServerCertificate=True;"))
                    {
                        conexion.Open();

                        // Insertar cada producto del carrito en la base de datos
                        foreach (DataGridViewRow row in dgvCarrito.Rows)
                        {
                            if (row.Cells["id_videojuego"].Value != null)
                            {
                                int id_videojuego = Convert.ToInt32(row.Cells["id_videojuego"].Value);
                                int cantidad = Convert.ToInt32(row.Cells["cantidad"].Value);
                                precio = Convert.ToDecimal(row.Cells["precio"].Value);
                                decimal montoProducto = precio * cantidad;

                                // Insertar la venta de cada videojuego en la base de datos
                                string query = "INSERT INTO Ventas (fecha_venta, id_cliente, id_videojuego, cantidad, monto_total) " +
                                               "VALUES (@fecha_venta, @id_cliente, @id_videojuego, @cantidad, @monto_total)";

                                using (SqlCommand cmd = new SqlCommand(query, conexion))
                                {
                                    cmd.Parameters.AddWithValue("@fecha_venta", DateTime.Now);
                                    cmd.Parameters.AddWithValue("@id_cliente", id_cliente);
                                    cmd.Parameters.AddWithValue("@id_videojuego", id_videojuego);
                                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                                    cmd.Parameters.AddWithValue("@monto_total", montoProducto); // Usamos el monto individual para cada videojuego

                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }

                        // Mostrar mensaje de éxito
                        MessageBox.Show($"¡Compra finalizada exitosamente! Monto Total con descuento: {monto_total:C}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvCarrito.Rows.Clear();  // Limpiar el carrito
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al finalizar la compra: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (Cupon == "BUENFIN")
            {
                descuento = monto_total * 0.35m;  // 35% de descuento
                decimal precio = monto_total - descuento;

                monto_total -= descuento;
                try
                {
                    using (SqlConnection conexion = new SqlConnection("Server=LAPTOP-F9DVQSMH;Database=TiendaVideojuegos;Trusted_Connection=True;TrustServerCertificate=True;"))
                    {
                        conexion.Open();

                        // Insertar cada producto del carrito en la base de datos
                        foreach (DataGridViewRow row in dgvCarrito.Rows)
                        {
                            if (row.Cells["id_videojuego"].Value != null)
                            {
                                int id_videojuego = Convert.ToInt32(row.Cells["id_videojuego"].Value);
                                int cantidad = Convert.ToInt32(row.Cells["cantidad"].Value);
                                precio = Convert.ToDecimal(row.Cells["precio"].Value);
                                decimal montoProducto = precio * cantidad;

                                // Insertar la venta de cada videojuego en la base de datos
                                string query = "INSERT INTO Ventas (fecha_venta, id_cliente, id_videojuego, cantidad, monto_total) " +
                                               "VALUES (@fecha_venta, @id_cliente, @id_videojuego, @cantidad, @monto_total)";

                                using (SqlCommand cmd = new SqlCommand(query, conexion))
                                {
                                    cmd.Parameters.AddWithValue("@fecha_venta", DateTime.Now);
                                    cmd.Parameters.AddWithValue("@id_cliente", id_cliente);
                                    cmd.Parameters.AddWithValue("@id_videojuego", id_videojuego);
                                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                                    cmd.Parameters.AddWithValue("@monto_total", montoProducto); // Usamos el monto individual para cada videojuego

                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }

                        // Mostrar mensaje de éxito
                        MessageBox.Show($"¡Compra finalizada exitosamente! Monto Total con descuento: {monto_total:C}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvCarrito.Rows.Clear();  // Limpiar el carrito
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al finalizar la compra: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                descuento = 0;
                decimal precio = monto_total - descuento;

                monto_total -= descuento;
                try
                {
                    using (SqlConnection conexion = new SqlConnection("Server=LAPTOP-F9DVQSMH;Database=TiendaVideojuegos;Trusted_Connection=True;TrustServerCertificate=True;"))
                    {
                        conexion.Open();

                        // Insertar cada producto del carrito en la base de datos
                        foreach (DataGridViewRow row in dgvCarrito.Rows)
                        {
                            if (row.Cells["id_videojuego"].Value != null)
                            {
                                int id_videojuego = Convert.ToInt32(row.Cells["id_videojuego"].Value);
                                int cantidad = Convert.ToInt32(row.Cells["cantidad"].Value);
                                precio = Convert.ToDecimal(row.Cells["precio"].Value);
                                decimal montoProducto = precio * cantidad;

                                // Insertar la venta de cada videojuego en la base de datos
                                string query = "INSERT INTO Ventas (fecha_venta, id_cliente, id_videojuego, cantidad, monto_total) " +
                                               "VALUES (@fecha_venta, @id_cliente, @id_videojuego, @cantidad, @monto_total)";

                                using (SqlCommand cmd = new SqlCommand(query, conexion))
                                {
                                    cmd.Parameters.AddWithValue("@fecha_venta", DateTime.Now);
                                    cmd.Parameters.AddWithValue("@id_cliente", id_cliente);
                                    cmd.Parameters.AddWithValue("@id_videojuego", id_videojuego);
                                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                                    cmd.Parameters.AddWithValue("@monto_total", montoProducto); // Usamos el monto individual para cada videojuego

                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }

                        // Mostrar mensaje de éxito
                        MessageBox.Show($"¡Compra finalizada exitosamente! Monto Total con descuento: {monto_total:C}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvCarrito.Rows.Clear();  // Limpiar el carrito
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al finalizar la compra: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private double Descuento()
        {
            String Cupon = txt_cupon.Text;
            int cuponn = 0;

            if (Cupon == "1COMPRA")
            {
                cuponn = (int)Math.Round(cantidad * 0.10);
                cantidad = cantidad - cuponn;
            }
            else if (Cupon == "FELIZCUMPLE")
            {
                cuponn = (int)Math.Round(cantidad * 0.25);
                cantidad = cantidad - cuponn;
            }
            else if (Cupon == "BUENFIN")
            {
                cuponn = (int)Math.Round(cantidad * 0.35);
                cantidad = cantidad - cuponn;
            }

            return cantidad;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Cupon = txt_cupon.Text;

            if (Cupon == "1COMPRA")
            {
                MessageBox.Show("Cupon aplicado correctamente");
            }
            else if (Cupon == "FELIZCUMPLE")
            {
                MessageBox.Show("Cupon aplicado correctamente");
            }
            else if (Cupon == "BUENFIN")
            {
                MessageBox.Show("Cupon aplicado correctamente");
            }
            else
            {
                MessageBox.Show("Cupon Inexistente");
            }
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo para solicitar la contraseña
            string inputPassword = Microsoft.VisualBasic.Interaction.InputBox(
                "Por favor, ingrese la contraseña de administrador:",
                "Autenticación requerida",
                "");

            // Validar la contraseña
            if (inputPassword == "1234") // Contraseña de administrador
            {
                // Si es correcta, abrir el nuevo frame (formulario de administrador)
                FrmDatos datos = new FrmDatos();
                datos.Show();

            }
            else
            {
                // Mostrar un mensaje de error si la contraseña no es correcta
                MessageBox.Show("Contraseña incorrecta. Acceso denegado.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnDevolucion_Click(object sender, EventArgs e)
        {
            string idClienteStr = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el ID del cliente:", "ID Cliente");
            string idVideojuegoStr = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el ID del videojuego: " +
                "\n1.-\tThe Legend of Zelda: Breath of the Wild\r\n2.-\tGod of War Ragnarök\r\n3.-\tHalo Infinite\r\n4.-\tAssassins Creed Valhalla\r\n5.-\tGrand Theft Auto V\r\n6.-\tThe Elder Scrolls V: Skyrim\r\n7.-\tFinal Fantasy VII Remake\r\n8.-\tResident Evil Village\r\n9.-\tFC 25\r\n10.-\tCyberpunk 2077\r\n11.-\tMario Kart 8 Deluxe\r\n12.-\tThe Witcher 3: Wild Hunt\r\n13.-\tMinecraft\r\n14.-\tOverwatch 2\r\n15.-\tAnimal Crossing: New Horizons\r\n16.-\tDoom Eternal\r\n17.-\tForza Horizon 5\r\n18.-\tThe Sims 4\r\n19.-\tDark Souls III\r\n20.-\tAmong Us\r\n21.-\tDetroit Become Human\r\n22.-\tHollow Knight\r\n23.-\tCeleste\r\n24.-\tStardew Valley\r\n25.-\tHades\r\n26.-\tThe Last of Us Part II\r\n27.-\tSekiro: Shadows Die Twice\r\n28.-\tMonster Hunter: World\r\n29.-\tFall Guys: Ultimate Knockout\r\n30.-\tControl\r\n31.-\tRed Dead Redemption 2\r\n32.-\tMADDEN 25", "ID Videojuego");
            string cantidadStr = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad de videojuegos a devolver:", "Cantidad");
            string motivo = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el motivo de la devolución:", "Motivo");

            // Validar que los campos no estén vacíos
            if (string.IsNullOrEmpty(idClienteStr) || string.IsNullOrEmpty(idVideojuegoStr) || string.IsNullOrEmpty(cantidadStr) || string.IsNullOrEmpty(motivo))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Convertir las cadenas a tipos adecuados
            int idCliente = int.Parse(idClienteStr);
            int idVideojuego = int.Parse(idVideojuegoStr);
            int cantidad = int.Parse(cantidadStr);

            // Crear un objeto Devoluciones con los datos ingresados
            Devoluciones devolucion = new Devoluciones
            {
                fecha_devolucion = DateTime.Now,  // Fecha actual como fecha de la devolución
                id_cliente = idCliente,
                id_videojuego = idVideojuego,
                cantidad = cantidad,
                motivo = motivo
            };

            // Llamar al método para agregar la devolución
            int resultDevolucion = DevolucionesDAL.AgregarDevolucion(devolucion);

            if (resultDevolucion > 0)
            {
                // Ahora eliminar la venta relacionada
                int resultVenta = VentasDAL.EliminarVenta(idCliente, idVideojuego);

                // Verificar el resultado de la eliminación
                if (resultVenta > 0)
                {
                    MessageBox.Show("Devolución registrada y venta eliminada correctamente.");
                }
                else
                {
                    MessageBox.Show("Devolucion Realizada.");
                }
            }
            else
            {
                MessageBox.Show("Error al registrar la devolución.");
            }
        }

        
    }
}
