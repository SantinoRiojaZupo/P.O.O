using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Paises
        //4. Cargar en un vector los nombres de 5 países y en otro vector paralelo la cantidad de habitantes de este.
        //Ordenar alfabéticamente e imprimir los resultados.
        //Por último ordenar con respecto a la cantidad de habitantes(de mayor a menor) e imprimir nuevamente.
        
    {
        private string[] paises;
        private int[] habitantes;

        public void cargar()
        { 
         paises = new string[5];
         habitantes = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese el nombre del pais "+ i + ":");
                paises[i] = Console.ReadLine();
                Console.WriteLine("Ingrese la poblacion del pais");
                habitantes[i] = int.Parse(Console.ReadLine());
            }
        }
        public void ordenarAlfabeticamente()
        {
            for (int i = 0; i < paises.Length; i++)
            {
                for (int j = 0; j < paises.Length - 1; j++)
                {
                    if (String.Compare(paises[j], paises[j + 1]) > 0)
                    {
                        string tempPais = paises[j];
                        int tempHabitantes = habitantes[j];
                        paises[j] = paises[j + 1];
                        habitantes[j] = habitantes[j + 1];
                        paises[j + 1] = tempPais;
                        habitantes[j + 1] = tempHabitantes;
                    }
                }
            }
        }
        public void imprimirAlfabeticamente()
        {
            Console.WriteLine("Ordenado alfabeticamente: ");
            for (int i = 0; i < paises.Length; i++)
            {
                
                Console.WriteLine("Pais: " + paises[i] + " - Habitantes: " + habitantes[i]);
            }
        }
        public void ordenarPorHabitantes()
        {
            for (int i = 0; i < habitantes.Length; i++)
            {
                for (int j = 0; j < habitantes.Length - 1; j++)
                {
                    if (habitantes[j] > habitantes[j + 1])
                    {
                        string tempPais = paises[j];
                        int tempHabitantes = habitantes[j];
                        paises[j] = paises[j + 1];
                        habitantes[j] = habitantes[j + 1];
                        paises[j + 1] = tempPais;
                        habitantes[j + 1] = tempHabitantes;
                    }
                }
            }
        }
        public void imprimirPorHabitantes()
        {
            Console.WriteLine("Ordenado por habitantes: ");
            for (int i = 0; i < paises.Length; i++)
            {
                    
                Console.WriteLine("Pais: " + paises[i] + " - Habitantes: " + habitantes[i]);
            }
        }

        static void Main(string[] args)
        {
            Paises paises1 =new Paises();
            paises1.cargar();
            paises1.ordenarAlfabeticamente();
            paises1.imprimirAlfabeticamente();
            paises1.ordenarPorHabitantes();
            paises1.imprimirPorHabitantes();
            Console.ReadKey();
        }
    }
}
