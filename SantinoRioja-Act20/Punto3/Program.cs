using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{/*Actividad 3: Estadísticas de visitas a zonas arqueológicas
Problema:
Un instituto de arqueología desea registrar las visitas semanales a 3 zonas arqueológicas durante 4 semanas.
Plantear una matriz de 3x4 donde las filas representan las zonas y las columnas los días.
Luego:
 Calcular el total de visitas por zona y almacenarlo en un vector.
 Mostrar los datos en forma tabular.
 Agregar estos resultados a una lista llamada zonasVisitadas que contenga nombres de zonas y total de visitas.
 Determinar cuál fue la zona más visitada.*/
    

    internal class Program
    {

        static void Main(string[] args)
        {
            int[,] zonasArq = new int[3, 4];
            int[] totalZon = new int[3];
            List<(string zonas, int totalEnZonas)> zonasVisitadas = new List<(string, int)>();
            
            int total = 0;
            int masVisitada = 0;
            for(int i =0;i<3;i++)
            {
                Console.WriteLine("Zona:" + i);
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("Dia:" + j);
                    Console.WriteLine("Ingrese el total de visitas");
                    zonasArq[i,j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
            Console.WriteLine("Zonas:");
            for (int i = 0; i < 3; i++) {
                Console.WriteLine();
                total = 0;
                Console.Write("Zona:" + (i + 1));
                for (int j = 0; j < 4; j++) {
                    Console.Write("  " + zonasArq[i, j] + "  ");
                    total = total + zonasArq[i, j];
                }
                totalZon[i] = total;
                zonasVisitadas.Add(($"Zona:{i} ",total));
                Console.Write("  Total:"+ totalZon[i]);
                Console.WriteLine();
            }
            foreach (var  m in zonasVisitadas)
            {
                if (m.totalEnZonas > masVisitada)
                {
                    masVisitada = m.totalEnZonas;
                }
            }
            foreach(var m in zonasVisitadas)
            {
                if (m.totalEnZonas == masVisitada)
                {
                    Console.WriteLine();
                    Console.WriteLine($"La zona mas visitada fue la {m.zonas} Con {m.totalEnZonas} visitantes");
                }
            }
            Console.ReadKey(); 
        }
    }
}
