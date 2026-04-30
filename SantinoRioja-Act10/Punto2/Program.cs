using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class matriz
    {//2- Crear una matriz de n * m filas (cargar n y m por teclado)
     //Intercambiar la primer fila con la segunda.Imprimir luego la matriz.
        private int[,] mat;
        private int filas, columnas;
        public void cargar()
        {
            Console.WriteLine("Ingrese la cantidad de filas");
            filas= int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de columnas");
            columnas=int.Parse(Console.ReadLine());
            mat= new int[filas,columnas];
            for (int i=0; i<filas; i++)
            { for (int j = 0; j < columnas; j++) 
                {
                    Console.WriteLine("Ingrese el numero para la matriz en fila:"+i+" columna:"+j);
                    mat[i,j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public void intercambiar(){
            int aux = mat[0, 0];
            for (int i=0;i<columnas;i++)
            {
                 aux = mat[0, i];
                mat[0, i] = mat[1,i];
                mat[1, i] = aux;
            }
        }
        public void imprimir()
        {
            for (int i=0;i<filas;i++)
            {
                for (int j=0;j<columnas;j++)
                {
                    Console.WriteLine(mat[i,j]);
                }
            }
        }
        static void Main(string[] args)
        {
            matriz matriz1 = new matriz();
            matriz1.cargar();
            matriz1.intercambiar();
            matriz1.imprimir();
            Console.ReadKey();
        }
    }
}
