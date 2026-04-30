using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class verticesMatriz
    {
        //3- Crear una matriz de n * m filas (cargar n y m por teclado)
        //Imprimir los cuatro valores que se encuentran en los vértices de la misma(mat[0][0]etc.)
        private int[,] mat;
        private int filas, columnas;
        public void cargar()
        {
            Console.WriteLine("Ingrese la cantidad de filas");
            filas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de columnas");
            columnas = int.Parse(Console.ReadLine());
            mat = new int[filas, columnas];
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.WriteLine("Ingrese el numero para la matriz en fila:" + i + " columna:" + j);
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public void imprimirVertices()
        {
            Console.WriteLine("Vertice 1: " + mat[0, 0]);
            Console.WriteLine("Vertice 2: " + mat[0, columnas - 1]);
            Console.WriteLine("Vertice 3: " + mat[filas - 1, 0]);
            Console.WriteLine("Vertice 4: " + mat[filas - 1, columnas - 1]);
        }

        static void Main(string[] args)
        {
            verticesMatriz verticesMatriz1 = new verticesMatriz();
            verticesMatriz1.cargar();
            verticesMatriz1.imprimirVertices();
            Console.ReadKey();
        }
    }
}
