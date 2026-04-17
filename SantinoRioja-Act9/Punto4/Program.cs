using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Program
        //4. Se realiza una evaluación a 6 docentes por parte de sus alumnos.
        //Se registran sus nombres y puntajes promedio obtenidos(de 1 a 10).
        //Cargar sus datos en vectores paralelos,

        //mostrar docente con calificación más alta y más baja,

        //ordenar los vectores de mayor a menor de acuerdo con la calificación y
        //mostrar en pantalla la cantidad de docentes que aprobaron y desaprobaron(tomando como base que se aprueba con una nota mayor o igual a 6)
    {
        private string[] docentes;
        private float[] puntajes;
        private float masAlto, masBajo;

        public void cargar() {
            docentes = new string[6];
            puntajes = new float[6];
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Ingrese el nombre del profesor N°:" + (i + 1));
                docentes[i] = Console.ReadLine();
                Console.WriteLine("Ingrese un promedio de puntajes del 1 al 10");
                puntajes[i] = float.Parse(Console.ReadLine());
                if ((puntajes[i] < 1) || (puntajes[i] > 10))
                {
                    Console.WriteLine("Ingrese promedios que sean del 1 al 10 unicamente");
                    i--;
                }
            }
        }
        public void masBajoAlto()
        {
            masAlto = puntajes[0];
            masBajo = puntajes[0];
            for (int i = 1; i < 6; i++) {
                if (masAlto < puntajes[i])
                {
                    masAlto= puntajes[i];
                }
                if (masBajo > puntajes[i])
                {
                    masBajo= puntajes[i];
                }
            }
            for (int i = 0; i < 6; i++) {
                if (masAlto == puntajes[i]) {
                    Console.WriteLine("El docente con el promedio mas alto es:"+ docentes[i]);
                }
                if (masBajo == puntajes[i])
                {
                    Console.WriteLine("El docente con el promedio mas bajo es:" + docentes[i]);
                }
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
