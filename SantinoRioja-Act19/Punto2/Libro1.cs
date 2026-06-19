using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{

    partial class Libro
    {
        protected string titulo, autor;
        protected int paginas;
        public Libro()
        {
            Console.WriteLine("Ingrese titulo");
            titulo = Console.ReadLine();
            Console.WriteLine("Ingrese nombre del autor");
            autor = Console.ReadLine();
            Console.WriteLine("Ingrese cantidad de paginas, tiene que ser mayor a 10");
            paginas = int.Parse(Console.ReadLine());
            while (paginas < 11) {
                Console.WriteLine("La cantidad de paginas tiene que ser mayor a 10");
                paginas = int.Parse(Console.ReadLine());
            }
        }
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; } 
        }
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        public int Paginas
        {
            get { return paginas; }
            set { paginas = value; }
        }
    }
}
