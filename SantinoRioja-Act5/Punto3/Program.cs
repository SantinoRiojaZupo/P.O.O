using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3. Se realiza la carga de 10 valores enteros por teclado. Se desea conocer:
            //a) La cantidad de valores ingresados negativos.
            //b) La cantidad de valores ingresados positivos.
            //c) La cantidad de múltiplos de 15.
            //d) El valor acumulado de los números ingresados que son pares.
            int num, negativos = 0, positivos = 0, multiplos15 = 0, Pares = 0;
            for (int i = 1; i <= 10; i++) { 
             Console.WriteLine("Ingrese numero entero");
                num = int.Parse(Console.ReadLine());

                if (num>=0) { positivos++; }
                if (num < 0) { negativos++; }
                if ((num%15) == 0) { multiplos15++; }
                if ((num % 2) == 0) { Pares+=num; }
            }
            Console.WriteLine("Los numeros negativos son:"+negativos);
            Console.WriteLine("Los numeros positivos son:" + positivos);
            Console.WriteLine("Los numeros multiplos de 15 son:" + multiplos15);
            Console.WriteLine("El valor acumulado de los numeros pares es de:" + Pares);
            Console.ReadKey();
        }
    }
}
