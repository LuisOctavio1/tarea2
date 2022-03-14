using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2.Ejercicio1
{
    internal class ControlEstanterias
    {
        public List<Estanteria> estanterias;

        public ControlEstanterias()
        {
            estanterias = new List<Estanteria>();
        }

        public Estanteria? BuscarEstanteria(int id)
        {
            Estanteria? est = estanterias.FirstOrDefault(u => u.IdEstanteria == id);
            return est;
        }

        public bool AgregarEstanterias(int numRepisas,int id)
        {
            if ( BuscarEstanteria(id) == null)
            {
                estanterias.Add(new Estanteria(numRepisas,id));
                return true;
            }
            return false;
        }

        public void ListarEstanterias()
        {
            foreach (Estanteria est in estanterias)
            {
                Console.WriteLine(est.ToString());
                Console.WriteLine("------------");
            }
        }

        public void VerEstanteria(int id)
        {
            Estanteria? est = BuscarEstanteria(id);
            if (est != null)
            {
                est.imprimirEstanteria();
            }
        }

        public int? BuscarPelicula(int id)
        {
            foreach (Estanteria est in estanterias)
            {
                int? i =  est.buscarPelicula(id);
                if (i != null)
                {
                    return est.IdEstanteria;
                }
            }

            return null;
        }

        public bool agregarPeliculaAEstanteria(int idEstanteria, Pelicula pelicula,int repisa)
        {
            Estanteria? estanteria = BuscarEstanteria(idEstanteria);
            if ( estanteria!= null && BuscarPelicula(pelicula.Id) == null)
            {
                if (estanteria.agregarPelicula(pelicula, repisa))
                {
                    return true;
                }

                return false;

            }
            return false;
        }

        public bool QuitarPelicula(int id)
        {
            int? estanteria = BuscarPelicula(id);
            if ( estanteria != null)
            {
                estanterias.FirstOrDefault(u => u.IdEstanteria == estanteria).quitarPelicula(id);
                return true;
            }

            return false;
        }

        public bool quitarEstanteria(int id)
        {
            Estanteria? est = estanterias.FirstOrDefault(u => u.IdEstanteria == id);
            if ( est != null)
            {
                estanterias.Remove(est);
                return true;
            }
            return false;
        }

        public void ImprimirEstanterias()
        {
            foreach (Estanteria est in estanterias)
            {
                est.imprimirEstanteria();
                Console.WriteLine("------------(abajo nueva estanteria)");
            }
        }
    }
}
