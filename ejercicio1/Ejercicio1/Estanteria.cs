using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2.Ejercicio1
{
    internal class Estanteria
    {
        private int numeroRepisas;
        private int idEstanteria;
        private List<Pelicula>[] peliculas;

        public int NumeroRepisas { get => numeroRepisas; set => numeroRepisas = value; }
        public int IdEstanteria { get => idEstanteria; set => idEstanteria = value; }
        internal List<Pelicula>[] Peliculas { get => peliculas; set => peliculas = value; }

        public Estanteria(int numeroRepisas, int idEstanteria)
        {
            this.NumeroRepisas = numeroRepisas;
            this.IdEstanteria = idEstanteria;
            this.peliculas = new List<Pelicula>[numeroRepisas];
            for(int i = 0; i < numeroRepisas; i++)
            {
                List < Pelicula > repisa = new List<Pelicula>();
                peliculas[i] =  repisa;
            }
        }

        

        public bool agregarPelicula(Pelicula pelicula, int repisa)
        {
            if(repisa <=NumeroRepisas && repisa >= 0)
            {
                if(buscarPelicula(pelicula.Id) == null)
                {
                    peliculas[repisa-1].Add(pelicula);
                    peliculas[repisa-1] = peliculas[repisa-1].OrderBy(u => u.ToString()).ToList();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
           
        }

        public int? buscarPelicula(int id)
        {
            for(int i = 0;i < NumeroRepisas; i++)
            {
                if(peliculas[i].FirstOrDefault(u => u.Id == id) != null)
                {
                    return i;    
                }
            }
            return null;
        }
        public Pelicula obtenerPilicula(int id)
        {
            for (int i = 0; i < NumeroRepisas; i++)
            {
                Pelicula? pelicula = peliculas[i].FirstOrDefault(u => u.Id == id);
                if (pelicula != null)
                {
                    return pelicula;
                }
            }
            return null;
        }

        public bool quitarPelicula(int id)
        {
            Pelicula? pelicula = obtenerPilicula(id);
            int? repisas = buscarPelicula(id);
            if ( pelicula != null && repisas != null)
            {
                peliculas[(int)repisas].Remove(pelicula);
                return true;
            }
            return false;
        }

        public void imprimirEstanteria()
        {
           for(int i = 0; i < NumeroRepisas; i++)
           {
                List<Pelicula> pelis = Peliculas[i];
                foreach(Pelicula pe in pelis)
                {
                    Console.WriteLine(pe.ToString());
                }
                Console.WriteLine();
                Console.WriteLine("--------------------------");
           }
        }

        public String ToString()
        {
            return "Id estanteria : " + idEstanteria + "  Numero de repisas: " + numeroRepisas;
        }

        public void VerRepisa(int Repisa)
        {
            if (Repisa >= 0 && Repisa < numeroRepisas)
            {
                foreach (Pelicula pelicula in peliculas[Repisa])
                {
                    Console.WriteLine(pelicula.ToString());
                }
            }
            else
            {
                Console.WriteLine("Repisa fuera de rango");
            }
        }
    }
}
