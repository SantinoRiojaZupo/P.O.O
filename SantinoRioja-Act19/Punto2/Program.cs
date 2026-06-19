using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Program
    { /*2. Crear una clase parcial Libro.
En el primer archivo, declarar las propiedades Título, Autor y Páginas. Validar que la
cantidad de páginas sea mayor a 10. Valores cargados desde consola
En el segundo archivo, agregar un método Resumen() que muestre el título, autor y
si el libro es corto (menos de 100 páginas) o largo.
Desde la clase principal, cargar 2 libros y mostrar cuál es el más extenso.*/
        static void Main(string[] args)
        {
            Libro libro1 = new Libro();
            Libro libro2 = new Libro();
            if (libro1.Paginas > libro2.Paginas)
            { Console.WriteLine("El libro mas extenso es:");
                libro1.Resumen();
            }
            else { Console.WriteLine("El libro mas extenso es:");
                libro2.Resumen();
            }
            Console.ReadKey();
        }
    }
}
