using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3. Realizar un programa que lea cuatro valores numéricos e informar su suma y promedio.
             int numero1, numero2, numero3, numero4;
             Console.WriteLine("Ingrese el primer numero: ");
             numero1 = int.Parse(Console.ReadLine());
 
             Console.WriteLine("Ingrese el segundo numero: ");
             numero2 = int.Parse(Console.ReadLine());
 
             Console.WriteLine("Ingrese el tercer numero: ");
             numero3 = int.Parse(Console.ReadLine());
 
             Console.WriteLine("Ingrese el cuarto numero: ");
             numero4 = int.Parse(Console.ReadLine());
 
            float suma=(numero1+numero2+numero3+numero4);
            float promedio=suma/4;
            Console.WriteLine("suma de los numeros:"+ suma);
             Console.WriteLine("promedio de los numeros:"+ promedio);
            Console.ReadKey();
        }
    }
}
