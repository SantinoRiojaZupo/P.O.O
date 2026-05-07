using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Matriz
    {
        /*2. Confeccionar una clase para administrar una matriz irregular de 5 filas y 1 columna
        la primer fila, 2 columnas la segunda fila y así sucesivamente hasta 5 columnas la última fila
        (crearla sin la intervención del operador)
        Realizar la carga por teclado e imprimir posteriormente.*/
        private int[][] matriz;
        public void crear()
        {
            matriz = new int[5][];
            for (int i = 0; i < matriz.Length; i++)
            {
                matriz[i]=new int[i+1];
            }
        }
        public void cargar() {
        for (int i = 0;i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz[i].Length; j++)
                {
                    Console.WriteLine("Ingrese un valor para la matriz en fila:"+i+" columna:"+j);
                    matriz[i][j]=int.Parse(Console.ReadLine());
                }
            }
        }
        public void imprimir() { 
        for (int i = 0;i<matriz.GetLength(0);i++)
            {
                Console.WriteLine("Matriz"+i);
                for (int j = 0;j<matriz[i].Length;j++)
                {
                    Console.WriteLine(matriz[i][j] +" ");
                }
            }
        }
        static void Main(string[] args)
        {
            Matriz matriz1 = new Matriz();
            matriz1.crear();
            matriz1 .cargar();
            matriz1.imprimir();
            Console.ReadKey();
        }
    }
}
