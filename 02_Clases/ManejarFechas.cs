using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Xml.Schema;

namespace _02_Clases
{
    class ManejarFechas
    {
        public void Menu()
        {
            String opcion;

            Console.WriteLine("1. Dia Semana");
            Console.WriteLine("2. Incrementar Fecha");
            Console.WriteLine("3. Diferencia Fechas");
            Console.WriteLine("4. Compara Fechas");
            Console.WriteLine("Elige una opcion");

            opcion = Console.ReadLine();
            int year, month, day;
            int year2, month2, day2;
            DateTime dt, dt2;
            switch (opcion)
            {
                case "1":

                    Console.WriteLine("Introduce el dia");
                    day = int.Parse(Console.ReadLine());
                    Console.WriteLine("Introduce el mes");
                    month = int.Parse(Console.ReadLine());
                    Console.WriteLine("Introduce el año");
                    year = int.Parse(Console.ReadLine());
                    dt = new DateTime(year, month, day);
                    if (dt.DayOfWeek == DayOfWeek.Monday)
                    {
                        Console.WriteLine("El dia de la semana es Lunes ");
                    }
                    else if (dt.DayOfWeek == DayOfWeek.Tuesday)
                    {
                        Console.WriteLine("El dia de la semana es Martes ");
                    }
                    else if (dt.DayOfWeek == DayOfWeek.Wednesday)
                    {
                        Console.WriteLine("El dia de la semana es Miercoles ");
                    }
                    else if (dt.DayOfWeek == DayOfWeek.Thursday)
                    {
                        Console.WriteLine("El dia de la semana es Jueves ");
                    }
                    else if (dt.DayOfWeek == DayOfWeek.Friday)
                    {
                        Console.WriteLine("El dia de la semana es Viernes ");
                    }
                    else if (dt.DayOfWeek == DayOfWeek.Saturday)
                    {
                        Console.WriteLine("El dia de la semana es Sabado ");
                    }
                    else if (dt.DayOfWeek == DayOfWeek.Sunday)
                    {
                        Console.WriteLine("El dia de la semana es Domingo ");
                    }
                    break;

                case "2":
                    Console.WriteLine("Introduce el dia");
                    day = int.Parse(Console.ReadLine());
                    Console.WriteLine("Introduce el mes");
                    month = int.Parse(Console.ReadLine());
                    Console.WriteLine("Introduce el año");
                    year = int.Parse(Console.ReadLine());
                    dt = new DateTime(year, month, day);
                    Console.WriteLine("La fecha introducida es : " + dt.ToString("dd/MM/yy") + " sumandole tres dias es: " + dt.AddDays(3).ToString("dd/MM/yy"));
                    break;

                case "3":
                    Console.WriteLine("Introduce el dia de la primera fecha");
                    day = int.Parse(Console.ReadLine());
                    Console.WriteLine("Introduce el mes de la primera fecha");
                    month = int.Parse(Console.ReadLine());
                    Console.WriteLine("Introduce el año de la primera fecha");
                    year = int.Parse(Console.ReadLine());
                    dt = new DateTime(year, month, day);
                    Console.WriteLine("Introduce el dia de la segunda fecha");
                    day2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Introduce el mes de la segunda fecha");
                    month2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Introduce el año de la segunda fecha");
                    year2 = int.Parse(Console.ReadLine());
                    dt2 = new DateTime(year2, month2, day2);
                    TimeSpan tiempo = dt2.Subtract(dt);
                    int years = (int)(tiempo.TotalDays / 365.25);
                    int months = (int)(((tiempo.TotalDays / 365.25) - years) * 12);
                    Console.WriteLine("La diferencia es de: " + years + " años, " + months + " meses y " + tiempo.Days +
                       " dias");
                    break;

                case "4":
                    Console.WriteLine("Introduce el dia de la primera fecha");
                    day = int.Parse(Console.ReadLine());
                    Console.WriteLine("Introduce el mes de la primera fecha");
                    month = int.Parse(Console.ReadLine());
                    Console.WriteLine("Introduce el año de la primera fecha");
                    year = int.Parse(Console.ReadLine());
                    dt = new DateTime(year, month, day);
                    Console.WriteLine("Introduce el dia de la segunda fecha");
                    day2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Introduce el mes de la segunda fecha");
                    month2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Introduce el año de la segunda fecha");
                    year2 = int.Parse(Console.ReadLine());
                    dt2 = new DateTime(year2, month2, day2);

                    int total = DateTime.Compare(dt, dt2);
                    if (total < 0)
                        Console.WriteLine("La primera fecha es anterior a la segunda");
                    else if (total == 0)
                        Console.WriteLine("La primera fecha es igual a la segunda");
                    else
                        Console.WriteLine("La primera fecha es posterior a la segunda");
                    break;




            }
        }

    }
}
