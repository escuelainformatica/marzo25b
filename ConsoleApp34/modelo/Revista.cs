using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34.modelo
{
    class Revista : Impreso
    {
        public Revista()
        {
        }

        public Revista(string nombre, string autor, int paginas)
        {
            Nombre = nombre;
            Autor = autor;
            Paginas = paginas;
        }

        public string Nombre {set; get;}
        public string Autor {set; get;}
        public int Paginas {set; get;}



    }
}
