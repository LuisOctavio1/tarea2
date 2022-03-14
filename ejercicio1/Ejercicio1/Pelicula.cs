using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2.Ejercicio1
{
    internal class Pelicula
    {
        private String nombre;
        private String director;
        private String productora;
        private String fechaSalida;
        private String edicion;
        private String genero;
        private int id;

        public Pelicula(string nombre, string director, string productora, string fechaSalida, string edicion, string genero, int id)
        {
            this.Nombre = nombre;
            this.Director = director;
            this.Productora = productora;
            this.FechaSalida = fechaSalida;
            this.Edicion = edicion;
            this.Genero = genero;
            this.Id = id;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Director { get => director; set => director = value; }
        public string Productora { get => productora; set => productora = value; }
        public string FechaSalida { get => fechaSalida; set => fechaSalida = value; }
        public string Edicion { get => edicion; set => edicion = value; }
        public string Genero { get => genero; set => genero = value; }
        public int Id { get => id; set => id = value; }

        public String ToString()
        {
            String cadena = "Genero: " + Genero + "  " +
                            "Director: " + Director + "  " +
                            "Productora: " + Productora + "  " +
                            "Fecha de salida: " + FechaSalida + "  " +
                            "Edicion: " + Edicion +"  " + "Nombre de la pelicula:" + Nombre + "  " +
                            "Id: " + Id;
            return cadena;
        }
    }
}
