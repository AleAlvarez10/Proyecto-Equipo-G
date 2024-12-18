using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_TBD_EquipoG.Clases
{
    internal class Ventas
    {
        public int? id_venta { get; set; }             // ID de la venta
        public DateTime? fecha_venta { get; set; }     // Fecha de la venta
        public int? id_cliente { get; set; }           // ID del cliente (FK)
        public int? id_videojuego { get; set; }        // ID del videojuego (FK)
        public int? cantidad { get; set; }            // Cantidad vendida
        public decimal? monto_total { get; set; }     // Monto total de la venta

        public Ventas() { }

        public Ventas(int id_venta, DateTime fecha_venta, int id_cliente, int id_videojuego, int cantidad, decimal monto_total)
        {
            this.id_venta = id_venta;
            this.fecha_venta = fecha_venta;
            this.id_cliente = id_cliente;
            this.id_videojuego = id_videojuego;
            this.cantidad = cantidad;
            this.monto_total = monto_total;
        }
    }
}
