using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2.Ejercicio1
{
    internal class MenuControlColeccion
    {
        public ControlEstanterias estaterias;

        public MenuControlColeccion(ControlEstanterias estaterias)
        {
            this.estaterias = estaterias;
        }

        public void imprimirMenuPrincipal()
        {
            Console.WriteLine("Bienvenido, ingresa la opcion que desees\n" +
                              "1. Agregar Estanteria\n" +
                              "2. Quitar Estanteria \n" +
                              "3. Ver todas las estanterias y peliculas en ellas \n" +
                              "4. Listar estanterias(sin las peliculas)\n" +
                              "5. Manejar estanteria en especifico \n" +
                              "6. Salir");
        }

        public  void imprimirMenu2()
        {
            Console.WriteLine("Ingresa la opcion que desees \n" +
                              "1. Agregar pelicula \n" +
                              "2. Quitar Pelicula \n" +
                              "3. Ver pelicula \n" +
                              "4. Ver estanteria \n" +
                              "5. Regresar");
        }

        public  void manejarMenu1()
        {
            int opcion = 0;
            do
            {
                imprimirMenuPrincipal();
            } while (!validarMenu(6,ref opcion));

            switch (opcion)
            {
                case 1:
                    agregarEstanteria();
                    break;
                case 2:
                    quitarEstanteria();
                    break;
                case 3:
                    verEstanteriasYPeliculas();
                    break;
                case 4:
                    ListarEstanterias();
                    break;
                case 5:
                    Console.Clear();
                    manejarMenu2();
                    break;
                case 6:
                    break;
            }
        }

        public void manejarMenu2()
        {
            Console.Clear();
            int opcion = 0;
            do
            {
                imprimirMenu2();
            } while (!validarMenu(5,ref opcion));
            switch (opcion)
            {
                case 1:
                    AgregarPelicula();
                    break;
                case 2:
                    QuitarPelicula();
                    break;
                case 3:
                    VerPelicula();
                    break;
                case 4:
                    verEstanteria();
                    break;
                case 5:
                    Console.Clear();
                    manejarMenu1();
                    break;
            }
        }

        public  bool validarMenu(int opciones, ref int opcionSeleccionada)
        {
            int n;
            if (int.TryParse(Console.ReadLine(), out n))
            {
                if (n <= opciones && n > 0)
                {
                    opcionSeleccionada = n;
                    return true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opcion invalida");
                    return false;
                }
                
            }
            Console.Clear();
            Console.WriteLine("Opcion invalida");
            return false;
        }

        public void agregarEstanteria()
        {
            Console.WriteLine("Ingresa el id de la estanteria"); 
            int id; 
            while(!int.TryParse(Console.ReadLine(), out id) && id > 0) 
            { 
                Console.WriteLine("Elemento invalido");
            }
            Console.WriteLine("Ingresa el numero de repisas"); 
            int repisas; 
            while(!int.TryParse(Console.ReadLine(), out repisas) && repisas >0) 
            { 
                Console.WriteLine("Elemento invalido");
            } 
            if (estaterias.AgregarEstanterias(repisas, id)) 
            { 
                Console.WriteLine("La estanteria se agrego correctamente\n" + 
                                  "Ingresa 'enter' para continuar");
                
                Console.ReadLine(); 
                Console.Clear();
                manejarMenu1();
            }
            else {
                Console.WriteLine("La estanteria no s pudo agregar\n" + 
                                  "Presiona 'enter' para continuar");
                Console.ReadLine(); 
                Console.Clear(); 
                manejarMenu1();
            }
        }

        public void quitarEstanteria()
        {
            int id=0;
            validarNumero(ref id);
            Console.WriteLine("Ingrese el id de la estanteria");
            if (estaterias.quitarEstanteria(id))
            {
                Console.WriteLine("Estanteria quitada correctamente\n" +
                                  "Ingresa enter para continuar");
                Console.ReadLine();
                Console.Clear();
                manejarMenu1();
            }
            else
            {
                Console.WriteLine("No se encontro la estanteria\n" +
                                  "Ingresa enter para continuar");
                Console.ReadLine();
                Console.Clear();
                manejarMenu1();
            }
        }

        public void validarNumero(ref int numero)
        {
            while(!int.TryParse(Console.ReadLine(), out numero) && numero > 0) 
            { 
                Console.WriteLine("Elemento invalido");
            }
        }

        public void verEstanteriasYPeliculas()
        {
            estaterias.ImprimirEstanterias();
            Console.WriteLine("Ingresa enter para continuar");
            Console.ReadLine();
            Console.Clear();
            manejarMenu1();
        }

        public void ListarEstanterias()
        {
            estaterias.ListarEstanterias();
            Console.WriteLine("Ingresa enter para continuar");
            Console.ReadLine();
            Console.Clear();
            manejarMenu1();
        }

        public void AgregarPelicula()
        {
            Console.WriteLine("Ingresa el nombre");
            String nombre = Console.ReadLine();
            Console.WriteLine("Ingresa el director");
            String director = Console.ReadLine();
            Console.WriteLine("Ingresa la productora");
            String productora = Console.ReadLine();
            Console.WriteLine("Ingresa la fecha de salida");
            String fechaSalida = Console.ReadLine();
            Console.WriteLine("Ingresa la edicion");
            String edicion = Console.ReadLine();
            Console.WriteLine("Ingresa el genero");
            String genero = Console.ReadLine();
            Console.WriteLine("Ingresa el id(numero mayor a 0)");
            int id = 0;
            validarNumero(ref id);
            Console.WriteLine("Ingresa el id de la estanteria");
            int idEstanteria = 0;
            validarNumero(ref idEstanteria);
            Console.WriteLine("Ingresa el numero de repisa");
            int repisa = 0;
            validarNumero(ref repisa);
            Pelicula pelicula = new Pelicula(nombre, director, productora, fechaSalida, edicion, genero, id);
            if (estaterias.agregarPeliculaAEstanteria(idEstanteria, pelicula, repisa))
            {
                Console.WriteLine("La pelicula se agrego correctamente\n" +
                                  "Presiona enter para continuar");
                Console.ReadLine();
                Console.Clear();
                manejarMenu2();
                
            }
            else
            {
                Console.WriteLine("No se pudo agregar la pelicula\n" +
                                  "Presiona enter para continuar");
                Console.ReadLine();
                Console.Clear();
                manejarMenu2();
            }
        }

        public void QuitarPelicula()
        {
            Console.WriteLine("Ingresa el id de la pelicula");
            int id = 0;
            validarNumero(ref id);
            if (estaterias.QuitarPelicula(id))
            {
                Console.WriteLine("La pelicula se elimino correctamente\n" +
                                  "Presiona enter para continuar");
                Console.ReadLine();
                Console.Clear();
                manejarMenu2();
            }
            else
            {
                Console.WriteLine("No se encontro la pelicula\n" +
                                  "Presiona enter para continuar");
                Console.ReadLine();
                Console.Clear();
                manejarMenu2();
            }
        }

        public void VerPelicula()
        {
            int id = 0;
            Console.WriteLine("Ingresa el id de la pelicula");
            validarNumero(ref id);
            int? idEstanteria = estaterias.BuscarPelicula(id);
            Console.WriteLine(idEstanteria);
            if (idEstanteria != null)
            {
               Pelicula pelicula = estaterias.BuscarEstanteria((int)idEstanteria).obtenerPilicula(id);
               Console.WriteLine(pelicula.ToString());
               Console.WriteLine("La pelicula esta en la estanteria: " + idEstanteria);
               Console.WriteLine("Ingresa enter para continuar");
               Console.ReadLine();
               Console.Clear();
               manejarMenu2();
               
            }
            else
            {
                Console.WriteLine("No se encontro la pelicula");
                Console.WriteLine("Ingresa enter para continuar");
                Console.ReadLine();
                Console.Clear();
                manejarMenu2();
            }
        }

        public void verEstanteria()
        {
            Console.WriteLine("Ingresa el id de la estanteria");
            int id = 0;
            validarNumero(ref id);
            Estanteria? estanteria = estaterias.BuscarEstanteria(id);
            if (estanteria != null)
            {
                estanteria.imprimirEstanteria();
                Console.WriteLine("Ingresa enter para continuar");
                Console.ReadLine();
                Console.Clear();
                manejarMenu2();
            }
            else
            {
                Console.WriteLine("La estanteria no existe");
                Console.WriteLine("Ingresa enter para continuar");
                Console.ReadLine();
                Console.Clear();
                manejarMenu2();
                
            }
        }
        
    }
}

