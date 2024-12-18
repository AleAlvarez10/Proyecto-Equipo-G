using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_TBD_EquipoG.Clases
{
    internal class Desarrolladores
    {
        public int? id_desarrollador { get; set; }     // ID del desarrollador
        public string? nombre_desarrollador { get; set; } // Nombre del desarrollador
        public string? pais { get; set; }             // País del desarrollador

        public Desarrolladores() { }

        public Desarrolladores(int id_desarrollador, string nombre_desarrollador, string pais)
        {
            this.id_desarrollador = id_desarrollador;
            this.nombre_desarrollador = nombre_desarrollador;
            this.pais = pais;
        }
    }
}
