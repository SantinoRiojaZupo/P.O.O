using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. Se ingresan tres valores por teclado, si todos son iguales se imprime la suma del primero con el segundo y a este resultado se lo multiplica por el tercero.
            int num1, num2, num3;

            Console.WriteLine("Escribi el primer numero");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escribi el segundo numero");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escribi el tercer numero");
            num3 = int.Parse(Console.ReadLine());

            if (num1 == num2 && num2 == num3)
            {   
                int suma = num1 + num2;
                Console.WriteLine("La suma del primer numero con el segundo es: " + suma);
                int resultado = suma * num3;
                Console.WriteLine("El resultado es: " + resultado);
            }
            else
            {
                Console.WriteLine("Los numeros no son iguales");
            }

            Console.ReadKey();
        }
    }
}
