using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class compararVectorEnteros
//3. Cargar un vector de n elementos de tipo entero.
// Ordenar posteriormente el vector (el orden lo pueden elegir ustedes).
    {
        private int[] vector;
        public void cargarVector()
        {
            Console.WriteLine("Ingrese el tamaño del vector:");
                        int tamaño = int.Parse(Console.ReadLine());
            vector = new int[tamaño];
            for (int i = 0; i < vector.Length; i++) {
                Console.WriteLine("Ingrese valor entero para la posicion " + i + ":");
                vector[i] = int.Parse(Console.ReadLine());
            }
        }
        public void ordenarVector()
        { 
            for (int i = 0; i <vector.Length;i++)
            {     for (int j = 0; j < vector.Length - 1; j++)
                {
                    if (vector[j] > vector[j + 1])
                    {
                        int temp = vector[j];
                        vector[j] = vector[j + 1];
                        vector[j + 1] = temp;
                    }
                }
            }
        }
        public void mostrarVector()
        {
            Console.WriteLine("Vector ordenado de menor a mayor:");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            compararVectorEnteros programa = new compararVectorEnteros();
            programa.cargarVector();
            programa.ordenarVector();
            programa.mostrarVector();
            Console.ReadKey();
        }
    }
}
