using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Equipo_G.Clases
{
    internal class Devoluciones
    {
        public int? id_devolucion { get; set; }    // ID de la devolución
        public DateTime? fecha_devolucion { get; set; }  // Fecha de la devolución
        public int? id_cliente { get; set; }       // ID del cliente (FK)
        public int? id_videojuego { get; set; }    // ID del videojuego (FK)
        public int? cantidad { get; set; }         // Cantidad de videojuegos devueltos
        public string? motivo { get; set; }        // Motivo de la devolución

        // Constructor por defecto
        public Devoluciones() { }

        // Constructor con todos los parámetros
        public Devoluciones(int? id_devolucion, DateTime? fecha_devolucion, int? id_cliente, int? id_videojuego, int? cantidad, string? motivo)
        {
            this.id_devolucion = id_devolucion;
            this.fecha_devolucion = fecha_devolucion;
            this.id_cliente = id_cliente;
            this.id_videojuego = id_videojuego;
            this.cantidad = cantidad;
            this.motivo = motivo;
        }
    }
}
