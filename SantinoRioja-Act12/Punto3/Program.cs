using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class gastronomia
        /*3. Academia de Gastronomía: Recetario Dinámico
Un chef instructor evalúa a 3 alumnos en un examen final.Cada alumno debe presentar
una cantidad distinta de platos(uno presenta 2 platos, otro 4 y otro 3).
● Definir un vector para los nombres de los alumnos.
● Definir una matriz irregular para cargar el puntaje obtenido(0 a 100) en cada plato
presentado.
● Métodos:
1. Cargar nombres y definir el tamaño de las filas según la cantidad de platos
de cada alumno.
2. Cargar los puntajes de cada plato validando que estén entre 0 y 100.
3. Mostrar el listado de alumnos y el puntaje de cada uno de sus platos.
4. Calcular el puntaje promedio de cada alumno e informar si está "Aprobado"
(promedio >= 70) o "Reprobado".
5. Determinar quién obtuvo el puntaje individual más alto en un solo plato(el
valor máximo de la matriz).*/
    {
        private string[] alumnos;
        private int [][] puntajes;
        public void cargar()
        {
            alumnos = new string[3];
            puntajes = new int[3][];
            puntajes[0] = new int[2];
            puntajes[1] = new int[4];
            puntajes[2] = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese el nombre del alumno " + i);
                alumnos[i] = Console.ReadLine();
                for (int j = 0; j<puntajes[i].Length;)
                {
                    Console.WriteLine("Ingrese el puntaje del plato " + j + " del alumno " + alumnos[i]);
                    int puntaje = int.Parse(Console.ReadLine());
                    if (puntaje >= 0 && puntaje <= 100)
                    {
                        puntajes[i][j] = puntaje;
                        j++;
                    }
                    else
                    {
                        Console.WriteLine("Puntaje inválido. Ingrese un valor entre 0 y 100.");
                    }
                }
            }
        }
        public void imprimir()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Alumno: " + alumnos[i]);
                for (int j = 0; j < puntajes[i].Length; j++)
                {
                    Console.WriteLine("Plato " + j + ": Puntaje " + puntajes[i][j]);
                }
            }
        }
        public void promedio()
        {
            for (int i = 0; i < 3; i++)
            {
                float suma = 0;
                for (int j = 0; j < puntajes[i].Length; j++)
                {
                    suma += puntajes[i][j];
                }
                float promedio = suma / puntajes[i].Length;
                Console.WriteLine("Promedio del alumno " + alumnos[i] + ": " + promedio);
                if (promedio >= 70)
                {
                    Console.WriteLine("Aprobado");
                }
                else
                {
                    Console.WriteLine("Reprobado");
                }
            }
        }
        public void puntajeMaximo()
        {
            int maximo = 0;
            string alumnoMaximo = "";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < puntajes[i].Length; j++)
                {
                    if (puntajes[i][j] > maximo)
                    {
                        maximo = puntajes[i][j];
                        alumnoMaximo = alumnos[i];
                    }
                }
            }
            Console.WriteLine("El puntaje más alto es " + maximo + " obtenido por el alumno " + alumnoMaximo);
        }
        static void Main(string[] args)
        {
            gastronomia gastronomia1 = new gastronomia();
            gastronomia1.cargar();
            gastronomia1.imprimir();
            gastronomia1.promedio();
            gastronomia1.puntajeMaximo();
            Console.ReadKey();
        }
    }
}
