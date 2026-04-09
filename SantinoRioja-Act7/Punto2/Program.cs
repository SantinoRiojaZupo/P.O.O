using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    //2. Realizar un programa que pida la carga de dos vectores numéricos enteros de 4 elementos.
    //Obtener la suma de los dos vectores, dicho resultado guardarlo en un tercer vector del mismo tamaño.
    //Sumar componente a componente.
    internal class sumaVectores
    {
        private int[] vector1;
        private int[] vector2;
        private int[] vector3;

        public void cargarVectores() { 
        vector1 = new int[4];
        vector2 = new int[4];
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Ingrese el elemento "+i+" del vector 1: ");
                vector1[i] = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el elemento " + i + " del vector 2: ");
                vector2[i] = int.Parse(Console.ReadLine());
            }
        }
        public void sumarVectores() {
            vector3 = new int[4];
        for (int i = 0; i < 4; i++)
            {
                vector3[i] = vector1[i] + vector2[i];
            }
        }
        public void imprimirVectores()
        {
            for (int i = 0; i < vector3.Length; i++)
            {
                Console.WriteLine("Vector 3 posicion "+i+": " + vector3[i]);
            }
        }
            static void Main(string[] args)
        {
            sumaVectores sumaVectores1 = new sumaVectores();
            sumaVectores1.cargarVectores();
            sumaVectores1.sumarVectores();
            sumaVectores1.imprimirVectores();
            Console.ReadKey();
        }
    }
}
