using ConsoleApp34.modelo;
using ConsoleApp34.servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Impreso> libros=new List<Impreso>();
            libros.Add(new Libro("libro1","autor1",20,2));
            var lib=new Libro("libro2","autor2",40,2);
            libros.Add(lib);
            libros.Add(new Libro 
                {Nombre="libro3"
                ,Autor="autor3",Paginas=250,Capitulos=50
                });

            List<Impreso> revistas=new List<Impreso>();
            revistas.Add(new Revista("caras","??",50));

            ImpresoServicio.Mostrar(libros);
            ImpresoServicio.Mostrar(revistas);


        }
    }
}
