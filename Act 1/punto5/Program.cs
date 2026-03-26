using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5. Realizar la carga del radio de un círculo, mostrar por pantalla la circunferencia y el área del mismo
            //(La circunferencia se calcula multiplicando el doble del radio por π (pi), y el área se calcula multiplicando π por el cuadrado del radio).

            int radioCirculo;

            double pi = Math.PI;

            Console.WriteLine("Ingrese el radio del circulo");
            radioCirculo = int.Parse(Console.ReadLine());

            double circunferencia= (radioCirculo * 2)*pi;
            double area= pi * (radioCirculo*radioCirculo);
            Console.WriteLine("La circunferencia del circulo es:"+ circunferencia);
            Console.WriteLine("El area del circulo es:"+ area);
            Console.ReadKey();
        }
    }
}
