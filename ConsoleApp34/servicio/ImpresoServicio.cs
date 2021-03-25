using ConsoleApp34.modelo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34.servicio
{
    class ImpresoServicio
    {
        public static void Mostrar(List<Impreso> libros)
        {
            foreach(var libro in libros)
            {
                Debug.WriteLine(libro.Autor);
            }
        }
    }
}
