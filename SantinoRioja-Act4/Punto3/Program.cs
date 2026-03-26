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
            //3. Realizar un programa que acumule (sume) valores ingresados por teclado hasta
            //ingresar el 9999(no sumar dicho valor, indica que ha finalizado la carga).Imprimir el
            //valor acumulado e informar si dicho valor es cero, mayor a cero o menor a cero.
            int valor = 0;
            int acumulado = 0;
            do
            {
                Console.WriteLine("Sume numeros, si es 9999 finaliza la carga");
                valor = int.Parse(Console.ReadLine());
                acumulado += valor;
                Console.WriteLine("valor acumulado: "+acumulado);
                if (acumulado == 0) { Console.WriteLine("El valor acumulado es cero"); }
                else if (acumulado > 0) { Console.WriteLine("El valor acumulado es mayor a cero"); }
                else { Console.WriteLine("El valor acumulado es menor a cero"); }

            } while (valor != 9999);
                if (valor == 9999) {  Console.WriteLine("Finalizo la carga") ; }
            Console.ReadKey();
        }
    }
}
