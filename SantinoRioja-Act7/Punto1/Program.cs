using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
    //1. Desarrollar un programa que permita ingresar un vector de 8 elementos, e informe:
    //El valor acumulado de todos los elementos del vector.
    //El valor acumulado de los elementos del vector que sean mayores a 36.
    //Cantidad de valores mayores a 50.
{
    internal class Programa
    {
        private int[] elementos;
        private int suma, mayores36, mayores50;
        public void IngresarElementos()
        {
            elementos = new int[8];
            for (int i = 0; i < 8; i++)
            {
                Console.Write("Ingrese el elemento "+i+": ");
                elementos[i] = int.Parse(Console.ReadLine());
            }

        }
        public void calcular() {
            suma = 0;
            mayores36 = 0;
            mayores50 = 0;
            for (int i = 0; i < elementos.Length; i++)
            {
                suma += elementos[i];
                if (elementos[i] > 36)
                {
                    mayores36 += elementos[i];
                }
                if (elementos[i] > 50)
                {
                    mayores50++;
                }
            }
        }
        public void Imprimir(){
            Console.WriteLine("Valor acumulado de todos los elementos:"+suma);
            Console.WriteLine("Valor acumulado de elementos mayores a 36:"+mayores36);
            Console.WriteLine("Cantidad de valores mayores a 50:"+mayores50);
        }
        static void Main(string[] args)
        {
            Programa programa = new Programa();
            programa.IngresarElementos();
            programa.calcular();
            programa.Imprimir();
            Console.ReadKey();
        }
    }
}
