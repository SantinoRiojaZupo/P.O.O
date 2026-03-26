using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace punto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. Escribir un programa en el cual se ingresen cuatro números, calcular e informar la suma de los dos primeros y el producto del tercero y el cuarto.
            int numero1, numero2, numero3, numero4;
            string linea;
            Console.Write("Ingrese el primer numero: ");
            linea = Console.ReadLine();
            numero1 = int.Parse(linea);

            Console.Write("Ingrese el segundo numero: ");
            linea = Console.ReadLine();
            numero2 = int.Parse(linea);

            Console.Write("Ingrese el tercer numero: ");
            linea = Console.ReadLine();
            numero3 = int.Parse(linea);

            Console.Write("Ingrese el cuarto numero: ");
            linea = Console.ReadLine();
            numero4 = int.Parse(linea);

            Console.Write("suma de 1 y 2:"+ (numero1+numero2));
            Console.WriteLine();
            Console.Write("producto de 3 y 4:"+ numero3*numero4);
            Console.ReadKey();
        }
    }
}
