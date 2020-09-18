using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _02_Clases
{
    class Pelicula
    {
        public void ListaPelicula()
        {
            String opcion;
            ArrayList lista = new ArrayList();
            do
            {

                Console.WriteLine("1. Insertar películas");
                Console.WriteLine("2. Ver Listado de Películas");
                Console.WriteLine("3. Modificar alguna película de las insertadas");
                Console.WriteLine("4. Eliminar alguna de las películas insertadas");
                Console.WriteLine("5. Salir");
                Console.WriteLine("Elige una opcion");

                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        String titulo, director;
                        ArrayList actotes = new ArrayList();

                        Console.WriteLine("Introduce el titulo de la pelicula");
                        titulo = Console.ReadLine();
                        Console.WriteLine("Introduce el director de la pelicula");
                        director = Console.ReadLine();

                        Peliculas peli = new Peliculas(titulo, director);
                        lista.Add(peli);
                        break;
                    case "2":
                        for (int i = 0; i < lista.Count; i++)
                        {
                            Peliculas p = (Peliculas)lista[i];
                            Console.WriteLine("Titulo de la pelicula: " + p.Titulo + " , Director: " + p.Director + " y Actores:");
                        }
                        break;
                    case "3":
                        String modificar;
                        Console.WriteLine("Introduce el titulo de la pelicula que quieres modificar<");
                        modificar = Console.ReadLine();
                        for (int i = 0; i < lista.Count; i++)
                        {
                            Peliculas p = (Peliculas)lista[i];
                            
                        }
                        break;
                    case "4":
                        String eliminar;
                        Console.WriteLine("Introduce el titulo de la pelicula que quieres eliminar");
                        eliminar = Console.ReadLine();
                        for (int i = 0; i < lista.Count; i++)
                        {
                            Peliculas p = (Peliculas)lista[i];
                            if (p.Titulo.Equals(eliminar)) { 
                                lista.Remove(p.Titulo.Equals(eliminar));
                                Console.WriteLine("La pelicula ha sido borrada de la lista");
                            }
                            
                        }
                        break;
                }


            } while (opcion != "5");
        }
    }
}
