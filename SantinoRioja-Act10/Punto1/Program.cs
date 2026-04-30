using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class matriz
        //1- Crear una matriz de 2 filas y 5 columnas.
        //Realizar la carga de componentes por columna(es decir primero ingresar toda la primer columna, luego la segunda columna y así sucesivamente)
        //Imprimir luego la matriz.
    {
        private int [,] mat;
        public void cargarMat()
        {
            mat= new int[2, 5];
            for (int i = 0;i<5;i++)
            {
                for (int j = 0;j<2;j++)
                {
                    Console.WriteLine("Ingrese el numero en la columna:"+i+" en la fila:"+j);
                    mat[j, i] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void imprimir()
        {
        for(int i = 0; i<5;i++)
            { for (int j = 0; j < 2; j++) { Console.WriteLine("Numero de matriz en columna:"+i+" fila:"+j+" " + mat[j,i]); } }
        }
        static void Main(string[] args)
        {
            matriz matriz1 = new matriz();
            matriz1.cargarMat();
            matriz1.imprimir();
            Console.ReadKey();
        }
    }
}
