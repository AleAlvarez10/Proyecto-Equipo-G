using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_TBD_EquipoG.Clases
{
    internal class Videojuegos
    {
        public int? id_videojuego { get; set; }        // ID del videojuego
        public string? titulo { get; set; }            // Título del videojuego
        public int? id_genero { get; set; }            // ID del género (FK)
        public int? id_desarrollador { get; set; }     // ID del desarrollador (FK)
        public decimal? precio { get; set; }          // Precio del videojuego
        public string? plataforma { get; set; }        // Plataforma
        public int? stock { get; set; }               // Stock disponible
        public string? descripcion { get; set; }      // Descripción

        public Videojuegos() { }

        public Videojuegos(int id_videojuego, string titulo, int id_genero, int id_desarrollador, decimal precio, string plataforma, int stock, string descripcion)
        {
            this.id_videojuego = id_videojuego;
            this.titulo = titulo;
            this.id_genero = id_genero;
            this.id_desarrollador = id_desarrollador;
            this.precio = precio;
            this.plataforma = plataforma;
            this.stock = stock;
            this.descripcion = descripcion;
        }
    }
}
