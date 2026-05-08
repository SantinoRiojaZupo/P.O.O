using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class trabajo
    { /* 3. Confeccionar una clase para administrar los días que han faltado los 3 empleados de una empresa.
Definir un vector de 3 elementos de tipo string para cargar los nombres y una matriz irregular para cargar los días que han faltado cada empleado (cargar el número de día que faltó)
Cada fila de la matriz representa los días de cada empleado.
a.Mostrar los empleados con la cantidad de inasistencias.
b.Cuál empleado faltó menos días.*/

        private string[] empleados;
        private int[][] diasFaltados;

        public void crear()
        {
            empleados = new string[3];
                        diasFaltados = new int[3][];
            for (int i = 0; i < 3; i++) {
                Console.WriteLine("Ingrese el nombre del empleado Nro:" + i);
                empleados[i] = Console.ReadLine();
                Console.WriteLine("Ingrese los dias que falto el empleado Nro:" + i);
                diasFaltados[i] = new int[int.Parse(Console.ReadLine())];
            }
        }
        public void cargar()
        {
            for (int i=0; i < 3; i++)
            {
                for (int j=0; j< diasFaltados[i].Length; j++)
                {
                    Console.WriteLine("Ingrese el dia que falto el empleado Nro:" + i);
                    diasFaltados[i][j] = int.Parse(Console.ReadLine());
                }
            }
        }
    public void imprimir()
        { 
            string empleadoMenosFaltas = empleados[0];
            int menor = diasFaltados[0].Length;
            for (int i=0;i< diasFaltados.Length; i++)
            {
                if (diasFaltados[i].Length < menor) {
                    menor = diasFaltados[i].Length;
                    empleadoMenosFaltas = empleados[i];
                }
                Console.WriteLine("Empleado Nro:" + i + " Inasistencias:"+ diasFaltados[i].Length);
            }
            Console.WriteLine("Empleado con menos faltas: " + empleadoMenosFaltas);
        }
        static void Main(string[] args)
        {
            trabajo trabajo1 = new trabajo();
            trabajo1.crear();
            trabajo1.cargar();
            trabajo1.imprimir();
            Console.ReadKey();
        }
    }
}
