using Microsoft.Data.SqlClient;
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
    public partial class FrmDatos : Form
    {
        public FrmDatos()
        {
            InitializeComponent();
        }

        private void btnTendencias_Click(object sender, EventArgs e)
        {


            List<(string titulo, int total_vendido)> juegosMasVendidos = VideojuegosDAL.ObtenerJuegosMasVendidos();

            // Configurar el DataGridView
            dgvDatos.DataSource = null; // Limpia los datos anteriores
            dgvDatos.Columns.Clear();

            // Crear columnas manualmente
            dgvDatos.Columns.Add("titulo", "Título");
            dgvDatos.Columns.Add("total_vendido", "Total Vendido");

            // Añadir filas con los datos obtenidos
            foreach (var juego in juegosMasVendidos)
            {
                dgvDatos.Rows.Add(juego.titulo, juego.total_vendido);
            }
        }

        private void btnMejoresClientes_Click(object sender, EventArgs e)
        {


            // Obtener los mejores clientes
            List<(int id_cliente, string nombre_cliente, int total_juegos, decimal monto_total)> mejoresClientes =
                VideojuegosDAL.ObtenerMejoresClientes();

            // Configurar el DataGridView
            dgvDatos.DataSource = null;
            dgvDatos.Columns.Clear();

            // Crear columnas
            dgvDatos.Columns.Add("id_cliente", "ID Cliente");
            dgvDatos.Columns.Add("nombre_cliente", "Nombre del Cliente");
            dgvDatos.Columns.Add("total_juegos", "Total Juegos Comprados");
            dgvDatos.Columns.Add("monto_total", "Monto Total Comprado");

            // Añadir filas
            foreach (var cliente in mejoresClientes)
            {
                dgvDatos.Rows.Add(cliente.id_cliente, cliente.nombre_cliente, cliente.total_juegos, cliente.monto_total);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvDatos.DataSource = null;

            var lista = VideojuegosDAL.ObtenerVentasPorGenero();
            dgvDatos.DataSource = null;
            dgvDatos.Columns.Clear();
            dgvDatos.DataSource = lista.Select(x => new
            {

                Genero = x.genero,
                TotalUnidadesVendidas = x.totalUnidades,
                MontoTotalGenerado = x.montoTotal
            }).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvDatos.DataSource = null;

            var lista = VideojuegosDAL.ObtenerVentasPorDesarrollador();
            dgvDatos.DataSource = null;
            dgvDatos.Columns.Clear();
            dgvDatos.DataSource = lista.Select(x => new
            {
                Desarrollador = x.desarrollador,
                MontoTotalGenerado = x.montoTotal
            }).ToList();
        }

        private void btnEliminarVideojuego_Click(object sender, EventArgs e)
        {
            // Solicitar los datos al usuario
            string titulo = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el título del videojuego:", "Nuevo Videojuego");
            string genero = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el ID del género:" +
                "\n1.-\tAcción\r\n2.-\tAventura\r\n3.-\tRPG\r\n4.-\tEstrategia\r\n5.-\tDeportes\r\n6.-\tSimulación\r\n7.-\tTerror\r\n8.-\tCarreras\r\n9.-\tPuzle\r\n10.-\tMultijugador masivo online", "Nuevo Videojuego");
            string desarrollador = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el ID del desarrollador: " +
                "\n1.-\tNintendo\r\n2.-\tSony Interactive Entertainment\r\n3.-\tMicrosoft Studios\r\n4.-\tUbisoft\r\n5.-\tRockstar Games\r\n6.-\tBethesda Softworks\r\n7.-\tSquare Enix\r\n8.-\tCapcom\r\n9.-\tElectronic Arts\r\n10.-\tCD Projekt Red", "Nuevo Videojuego");
            string precio = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el precio del videojuego:", "Nuevo Videojuego");
            string plataforma = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la plataforma del videojuego:", "Nuevo Videojuego");
            string stock = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el stock disponible:", "Nuevo Videojuego");
            string descripcion = Microsoft.VisualBasic.Interaction.InputBox("Ingrese una descripción del videojuego:", "Nuevo Videojuego");

            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(titulo) || string.IsNullOrWhiteSpace(genero) ||
                string.IsNullOrWhiteSpace(desarrollador) || string.IsNullOrWhiteSpace(precio) ||
                string.IsNullOrWhiteSpace(plataforma) || string.IsNullOrWhiteSpace(stock) ||
                string.IsNullOrWhiteSpace(descripcion))
            {
                MessageBox.Show("Todos los campos son requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Convertir los valores a los tipos adecuados
            int idGenero = Convert.ToInt32(genero);
            int idDesarrollador = Convert.ToInt32(desarrollador);
            decimal precioDecimal = Convert.ToDecimal(precio);
            int stockInt = Convert.ToInt32(stock);

            // Crear el objeto Videojuegos con los datos obtenidos
            Videojuegos videojuego = new Videojuegos
            {
                titulo = titulo,
                id_genero = idGenero,
                id_desarrollador = idDesarrollador,
                precio = precioDecimal,
                plataforma = plataforma,
                stock = stockInt,
                descripcion = descripcion
            };

            // Llamar al método AgregarVideojuego para insertar el videojuego
            bool resultado = VideojuegosDAL.AgregarVideojuego(videojuego);

            if (resultado)
            {
                MessageBox.Show("¡Videojuego agregado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al agregar el videojuego.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVentasRecientes_Click(object sender, EventArgs e)
        {

            dgvDatos.DataSource = null;
            dgvDatos.Columns.Clear();
            string query = @"
        SELECT TOP 5 v.id_venta, v.id_cliente, v.id_videojuego, v.fecha_venta, v.cantidad, v.monto_total
        FROM Ventas v
        ORDER BY v.fecha_venta DESC";

            using (SqlConnection conn = BD.obtenerConexion())
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Asignar los datos al DataGridView
                dgvDatos.DataSource = dt;
            }
        }
    }
}
