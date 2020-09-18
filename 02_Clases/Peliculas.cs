using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _02_Clases
{
    class Peliculas
    {
        String titulo, director;
        ArrayList listActores;

        public Peliculas(string titulo, string director) //, ArrayList listActores
        {
            this.titulo = titulo;
            this.director = director;
            //this.listActores = listActores;
        }

        public String Titulo
        {
            set
            {
                titulo = value;
            }
            get
            {
                return titulo;
            }
        }

        public String Director
        {
            set
            {
                director = value;
            }
            get
            {
                return director;
            }
        }

    }
}
