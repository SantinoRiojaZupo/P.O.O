using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4. Se debe desarrollar un programa que pida el ingreso del precio de un artículo y la cantidad que lleva el cliente. Mostrar lo que debe abonar el comprador.
            int precioArticulo, cantidad;
            Console.WriteLine("Ingrese el precio del articulo");
            precioArticulo = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el la cantidad que lleva el cliente:");
            cantidad = int.Parse(Console.ReadLine());

            Console.WriteLine("El cliente debe abonar:"+(precioArticulo*cantidad)+" pesetas");
            Console.ReadKey();
        }
    }
}
