using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Cuadrado
    {
        //2. Desarrollar una clase que represente un Cuadrado y tenga los siguientes
        //métodos: cargar el valor de su lado, imprimir su perímetro y su superficie.
        private int lado;

        public void cargarlado() {
            Console.WriteLine("Ingrese lado del cuadrado");
            lado = int.Parse(Console.ReadLine());
        }
        public void imprimir() {
            Console.WriteLine("El perimetro del cuadrado es: " + (lado*4));
            Console.WriteLine("La superficie del cuadrado es: " + (lado*lado));
        }
        static void Main(string[] args)
        {
            Cuadrado cuadrado1 = new Cuadrado();
            cuadrado1.cargarlado();
            cuadrado1.imprimir();
            Console.ReadKey();
        }
    }
}
