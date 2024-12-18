using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_TBD_EquipoG.Clases
{
    internal class Generos
    {
        public int? id_genero { get; set; }            // ID del género
        public string? nombre_genero { get; set; }     // Nombre del género

        public Generos() { }

        public Generos(int id_genero, string nombre_genero)
        {
            this.id_genero = id_genero;
            this.nombre_genero = nombre_genero;
        }
    }
}
