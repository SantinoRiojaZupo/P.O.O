using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5. Escribir un programa que pida ingresar la coordenada de un punto en el plano, es decir dos valores enteros x e y (distintos a cero).
            //Posteriormente imprimir en pantalla en que cuadrante se ubica dicho punto. (1º Cuadrante si x > 0 Y y > 0 , 2º Cuadrante: x < 0 Y y > 0). 
            int x, y;

            Console.WriteLine("Escribi coordenada x");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribi coordenada y");
            y = int.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Se encuentra en 1° Cuadrante");
            }
            if (x < 0 && y < 0) 
            {
                Console.WriteLine("Se encuentra en 2° Cuadrante");
            }
            Console.ReadKey();

        }
    }
}