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
            for (int i = 0; i < paises.Length ; i++)
            {
                for (int j = 0; j < paises.Length - 1 ; j++)
                {
                    if (String.Compare(paises[j], paises[j + 1]) > 0)
                    {
                        string temp = paises[j];
                        paises[j] = paises[j + 1];
                        paises[j + 1] = temp;
                    }
                }
            }
        }

        public void MostrarPaises()
        {
            Console.WriteLine("Paises ordenados alfabeticamente:");

            for (int i = 0;i < paises.Length;i++)
                {
                Console.WriteLine(paises[i]);
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
