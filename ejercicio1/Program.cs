// See https://aka.ms/new-console-template for more information

using Tarea2.Ejercicio1;

ControlEstanterias estanterias = new ControlEstanterias();
estanterias.AgregarEstanterias(3, 1);
estanterias.AgregarEstanterias(2, 2);
Pelicula pelicula = new Pelicula("La era de hielo", "Chris Wedge", "Blue Sky Studios", "14/03/02", "Especial", "Familiar", 1);
Pelicula pelicula1 = new Pelicula("Joker", "Todd Phillips", "DC Films", "3/10/19", "Estandar", "Drama", 2);
Pelicula pelicula2 = new Pelicula("Star Wars: Episodio II - El ataque de los clones", "George Lucas", "Lucasfilm", "16/04/02", "Coleccionista", "Blockbuster", 3);
Pelicula pelicula3 = new Pelicula("El padrino", "Francis Ford Coppola", "Paramount Pictures", "15/03/72", "50 aniversario", "Drama-Criminal", 4);
Pelicula pelicula4 = new Pelicula("El conjuro", "James Wan", "Warner Bros. Pictures", "19/07/13", "Estandar", "Genero", 5);
estanterias.agregarPeliculaAEstanteria(1, pelicula, 1);
estanterias.agregarPeliculaAEstanteria(1, pelicula1, 2);
estanterias.agregarPeliculaAEstanteria(1, pelicula2, 3);
estanterias.agregarPeliculaAEstanteria(2, pelicula3, 1);
estanterias.agregarPeliculaAEstanteria(2, pelicula4, 2);
MenuControlColeccion mwnu = new MenuControlColeccion(estanterias);
mwnu.manejarMenu1();


