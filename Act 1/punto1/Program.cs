using System;
using System.Runtime.Remoting.Messaging;

namespace punto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Realizar la carga del lado de un cuadrado, mostrar por pantalla el perímetro del mismo (El perímetro de un cuadrado se calcula multiplicando el valor del lado por cuatro)
            int ladoCuadrado=4;
            int perimetroCuadrado=ladoCuadrado*4;
            Console.WriteLine("El perímetro del cuadrado es: "+perimetroCuadrado);

        }
    }
}
