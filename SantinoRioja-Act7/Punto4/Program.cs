using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class MayorMenor
    {
        //4. Cargar un vector de 10 elementos y verificar posteriormente si el mismo está ordenado de menor a mayor y de mayor a menor.
        private int[] vector;
        private int menorMayor=0, mayorMenor=0;
        public void cargarVector()
        {
            vector = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese el numero "+i+": ");
                vector[i] = int.Parse(Console.ReadLine());
            }
        }
        public void verificarOrden() { 
            for (int i = 0; i < vector.Length-1; i++)
            {
                if (vector[i] < vector[i + 1])
                {
                    menorMayor++;
                }
                else { menorMayor = -10; }
                if (vector[i] > vector[i + 1])
                {
                    mayorMenor++;
                }
                else { mayorMenor = -10; }
            }
        }
        public void mostrarResultado() {
            if (menorMayor == 9)
            { Console.WriteLine("El vector esta ordenado de menor a mayor"); }
            else { Console.WriteLine("El vector no esta ordenado de menor a mayor"); }
            if (mayorMenor == 9)
            { Console.WriteLine("El vector esta ordenado de mayor a menor"); }
            else { Console.WriteLine("El vector no esta ordenado de mayor a menor"); }
        }

        static void Main(string[] args)
        {
            MayorMenor mayorMenor = new MayorMenor();
            mayorMenor.cargarVector();
            mayorMenor.verificarOrden();
            mayorMenor.mostrarResultado();
            Console.ReadKey();
        }
    }
}
