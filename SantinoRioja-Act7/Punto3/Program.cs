using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    //3. Pedir al usuario que ingrese las puntuaciones obtenidas en 6 partidas seguidas de un videojuego.
    //El programa debe:
    // Mostrar la puntuación más alta y la más baja.
    // Calcular el promedio de puntuación.
    // Contar cuántas veces superó los 500 puntos.
    internal class Puntuaciones
    {
        private int[] puntuaciones;
        private int max, min,promedio,mayor500;

        public void cargarPuntuaciones()
        {
            puntuaciones = new int[6];
            for (int i = 0; i < 6; i++)
            {
                Console.Write("Ingrese la puntuacion de la partida "+i+": ");
                puntuaciones[i] = int.Parse(Console.ReadLine());
            }
        }
        public void calculos()
        {
            for (int i = 0; i < puntuaciones.Length; i++)
            {
                if (i == 0)
                {
                    max = puntuaciones[i];
                    min = puntuaciones[i];
                }
                else
                {
                    if (puntuaciones[i] > max)
                    {
                        max = puntuaciones[i];
                    }
                    if (puntuaciones[i] < min)
                    {
                        min = puntuaciones[i];
                    }
                }
                promedio += puntuaciones[i];
                if (puntuaciones[i] > 500)
                {
                    mayor500++;
                }
            }
            promedio/=puntuaciones.Length;
        }
        public void mostrarResultados()
        {
            Console.WriteLine("La puntuacion mas alta es: "+max);
            Console.WriteLine("La puntuacion mas baja es: "+min);
            Console.WriteLine("El promedio de puntuacion es: "+promedio);
            Console.WriteLine("La cantidad de veces que supero los 500 puntos es: "+mayor500);
        }


        static void Main(string[] args)
        {
            Puntuaciones puntuaciones1 = new Puntuaciones();
            puntuaciones1.cargarPuntuaciones();
            puntuaciones1.calculos();
            puntuaciones1.mostrarResultados();
            Console.ReadKey();
        }
    }
}
