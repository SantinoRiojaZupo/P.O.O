using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class VectorMenor
    {
        //1. Cargar un vector de n elementos. imprimir el menor y un mensaje si se repite dentro del vector.
        private int[] vector;
        private int menor;

        public void CargarVector()
        {
            Console.WriteLine("Ingrse la cantidad de elementos del vector:");
            string input = Console.ReadLine();
            int n = int.Parse(input);
            vector = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Ingrese un numero para la posicion "+ i+ ":");
                vector[i] = int.Parse(Console.ReadLine());
            }
        }
        public void EncontrarMenor()
        {
            menor = vector[0];
            for (int i = 1; i < vector.Length; i++)
            {
                if (vector[i] < menor)
                {
                    menor = vector[i];
                }
            }
        }
        public void VerificarRepeticion()
        {
            int contador = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] == menor)
                {
                    contador++;
                }
            }
            Console.WriteLine("El menor numero es: " + menor);
            if (contador > 1)
            {
                Console.WriteLine("El numero " + menor + " se repite " + contador + " veces en el vector.");
            }
            else
            {
                Console.WriteLine("El numero " + menor + " no se repite en el vector.");
            }
        }

        static void Main(string[] args)
        {
            VectorMenor vectorMenor1 = new VectorMenor();
            vectorMenor1.CargarVector();
            vectorMenor1.EncontrarMenor();
            vectorMenor1.VerificarRepeticion();
            Console.ReadKey();
        }
    }
}
