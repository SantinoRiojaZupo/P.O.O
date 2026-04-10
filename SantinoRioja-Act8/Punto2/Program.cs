using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Program
    {
        //2. Definir un vector donde almacenar los nombres de 5 países.
        //Confeccionar el algoritmo de ordenamiento alfabético.

        private static string[] paises;

        public void CargarPaises()
        {
            paises = new string[5];
            for (int i = 0; i < paises.Length; i++)
            {
                Console.WriteLine("Ingrese el nombre del pais para la posicion " + i + ":");
                paises[i] = Console.ReadLine();
            }
        }

        public void OrdenarPaises()
        {
            Array.Sort(paises);
        }

        public void MostrarPaises()
        {
            Console.WriteLine("Paises ordenados alfabeticamente:");
            foreach (var pais in paises)
            {
                Console.WriteLine(pais);
            }
        }

        static void Main(string[] args)
        {
            Program programa = new Program();
            programa.CargarPaises();
            programa.OrdenarPaises();
            programa.MostrarPaises();
            Console.ReadKey();
        }
    }
}
