using System;

namespace _02_Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            String opcion;
            do
            {

                Console.WriteLine("1. Manejar Fechas");
                Console.WriteLine("2. Peliculas");
                Console.WriteLine("3. Alquiler Puerto");
                Console.WriteLine("4. Salir");
                Console.WriteLine("Elige una opcion");

                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        ManejarFechas m = new ManejarFechas();
                        m.Menu();
                        break;
                    case "2":
                        Pelicula p = new Pelicula();
                        p.ListaPelicula();
                        break;
                    case "3":
                        Alquileres a = new Alquileres();
                        a.AlquilerBarco();
                        break;
                    case "4":
                        Console.WriteLine("Adios!");
                        Environment.Exit(0);
                        break;

                }


            } while (opcion != "4");
        }
    }
}
