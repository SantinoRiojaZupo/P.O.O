using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    partial class Libro
    {
        public void Resumen()
        {
            Console.WriteLine("Titulo:" + Titulo);
            Console.WriteLine("Autor:" + Autor);
            if (Paginas < 100)
            {
                Console.WriteLine("El libro es corto");
            }
            else {
            Console.WriteLine("El libro es largo");
            }
        }
    }
}
