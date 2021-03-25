using ConsoleApp34.servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34.modelo
{
    class Libro : Impreso
    {
        public Libro()
        {
        }

        public string Nombre {set; get;}
        public string Autor {set; get;}
        public int Paginas {set; get;}
        public int Capitulos {set; get;}

        public Libro(string nombre, string autor, int paginas, int capitulos)
        {
            Nombre = nombre;
            Autor = autor;
            Paginas = paginas;
            Capitulos = capitulos;
        }
   

    }
}
