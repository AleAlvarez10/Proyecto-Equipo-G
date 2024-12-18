using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_TBD_EquipoG.Clases
{
    internal class Clientes
    {
        public int? id_cliente { get; set; }           // ID del cliente
        public string? nombre_cliente { get; set; }    // Nombre del cliente
        public string? correo { get; set; }            // Correo electrónico
        public string? telefono { get; set; }          // Teléfono

        public Clientes() { }

        public Clientes(int id_cliente, string nombre_cliente, string correo, string telefono)
        {
            this.id_cliente = id_cliente;
            this.nombre_cliente = nombre_cliente;
            this.correo = correo;
            this.telefono = telefono;
        }
    }
}
