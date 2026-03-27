using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Confeccionar un programa que permita ingresar un valor del 1 al 10 y nos
            //muestre la tabla de multiplicar del mismo(los primeros 13 términos)
            //Ejemplo: Si ingreso 3 deberá aparecer en pantalla los valores 3, 6, 9, hasta el 39.
            Console.WriteLine("ingrese un balor del 1 al 10");
            int num = int.Parse(Console.ReadLine());
            if (num<1 || num > 10) {
                Console.WriteLine("El numero no es valido"  );
                return;
            }
            Console.WriteLine("");
            for (int i = 1; i <= 13; i++) {
                Console.WriteLine(num*i);
            }
            Console.ReadKey();
        }
    }
}
