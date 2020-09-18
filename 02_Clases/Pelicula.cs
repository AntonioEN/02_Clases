using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Clases
{
    class Pelicula
    {
        public void ListaPelicula()
        {
            String opcion;
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
                        
                        break;
                    case "2":
                        
                        break;
                    case "3":
                       
                        break;
                    case "4":
                        
                        break;
                }


            } while (opcion != "5");
        }
    }
}
