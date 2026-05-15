using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Cine
    /* 2. Gestión de Complejo de Cine
Un cine tiene 4 salas con diferentes capacidades de espectadores(la Sala 1 tiene 10
asientos, la Sala 2 tiene 15, la Sala 3 tiene 8 y la Sala 4 tiene 12).
● Definir una matriz irregular de 4 filas para representar los asientos.
● Métodos:
1. Inicializar la matriz con los tamaños de las salas mencionadas(sin
intervención del operador).
2. Crear un método de  Venta de Entradas  que permita cargar la edad del
espectador en un asiento específico(fila y columna).
3. Imprimir el mapa de ocupación de las salas indicando la edad del espectador
en cada asiento.
4. Calcular cuántos menores de edad (menos de 18 años) hay en cada sala.
5. Informar cuál es el promedio de edad de los espectadores de todo el
complejo.*/
    {
        private int[] salas;
        private int[][] asientos;
        public void cargar()
        {
            salas = new int[4];
            asientos = new int[4][];
            asientos[0] = new int[10];
            asientos[1] = new int[15];
            asientos[2] = new int[8];
            asientos[3] = new int[12];
        }
        public void ventaEntradas()
        {
            while (true)
            {
                Console.WriteLine("Ingrese el numero de sala (0-3): o -1 para dejar de ingresar entradas");
                int sala = int.Parse(Console.ReadLine());
                if (sala == -1) { break; }
                Console.WriteLine("Ingrese el numero de asiento: " + "maxima cantidad de asientos en sala:" + asientos[sala].Length);
                int asiento = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la edad del espectador:");
                int edad = int.Parse(Console.ReadLine());
                if (sala >= 0 && sala < 4 && asiento >= 0 && asiento <= asientos[sala].Length && asientos[sala][asiento]==0)
                {
                    asientos[sala][asiento] = edad;
                }
                else
                {
                    Console.WriteLine("Número de sala o asiento inválido/ocupado.");
                }
               
            }
        }
        public void imprimir()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Sala " + (i) + ":");
                for (int j = 0; j < asientos[i].Length; j++)
                {

                    if (asientos[i][j] != 0)
                    {
                        Console.Write("asiento:" + j + " Edad:" + asientos[i][j] + " ");
                        Console.WriteLine();
                    }
                }
                Console.WriteLine();
            }
        }
        public void menores()
        {
            for (int i = 0; i < 4; i++)
            {
                int menores = 0;
                for (int j = 0; j < asientos[i].Length; j++)
                {
                    if (asientos[i][j] < 18 && asientos[i][j] !=0)
                    {
                        menores++;
                    }
                }
                Console.WriteLine("En la sala " + (i) + " hay " + menores + " menores de edad");
            }
        }
        public void promedio()
        {
            float espectadores = 0;
            float sumaEdades = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < asientos[i].Length; j++)
                {
                    if (asientos[i][j] != 0)
                    {
                        sumaEdades += asientos[i][j];
                        espectadores++;
                    }
                }
            }
            float promedio = sumaEdades / espectadores;
            Console.WriteLine("El promedio de edad de los espectadores es: " + promedio);
        }
        static void Main(string[] args)
        {
            Cine cine1= new Cine();
            cine1 .cargar();
            cine1.ventaEntradas();
            cine1.imprimir();
            cine1.menores();
            cine1.promedio();
            Console.ReadKey();
        }
    }
}