using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Empresa
        //2. Una empresa registra los nombres de sus 5 vendedores y el total de ventas realizadas por cada uno en un mes.
        //Cargar los nombres y ventas en dos vectores paralelos,
        //ordenar los datos de mayor a menor según las ventas,
        //imprimir la lista ordenada con nombre y monto de la venta, e informar quien fue el que menos vendió de los 5 empleados.
    {
        private string[] vendedores;
        private int[] ventas;
        public void cargar()
        {
            vendedores = new string[5];
            ventas = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese el nombre del vendedor en la posicion:" + i);
                vendedores[i]=Console.ReadLine();
                Console.WriteLine("Ingrese su total de ventas del mes:");
                ventas[i]=int.Parse(Console.ReadLine());
            }
        }
        public void ordenarVentas()
        {
            int aux = 0;
            string auxNomb;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (ventas[j] < ventas[j+1])
                    {
                        aux = ventas[j];
                        auxNomb= vendedores[j];
                        vendedores[j] = vendedores[j + 1];
                        vendedores[j + 1] = auxNomb;
                        ventas [j] = ventas[j+1];
                        ventas[j+1] = aux;
                    }
                }
            }
        }
        public void mostrar()
        {
            Console.WriteLine("Vendedores: ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(vendedores[i]+ " Ventas:"+ ventas[i]);
            }
            Console.WriteLine("El que tuvo menos ventas fue: "+ vendedores[4]);
        }
        static void Main(string[] args)
        {
            Empresa empresa1 = new Empresa();
            empresa1.cargar();
            empresa1.ordenarVentas();
            empresa1.mostrar();
            Console.ReadKey();
        }
    }
}
