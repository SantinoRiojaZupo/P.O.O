using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4. Se cuenta con la siguiente información:
            //● Las edades de 20 estudiantes del turno mañana.
            //● Las edades de 30 estudiantes del turno tarde.
            //● Las edades de 15 estudiantes del turno noche.
            //Las edades de cada estudiante deben ingresarse por teclado.
            //a) Obtener el promedio de las edades de cada turno(tres promedios)
            //b) Imprimir dichos promedios(promedio de cada turno)
            //c) Mostrar por pantalla un mensaje que indique cuál de los tres turnos tiene un promedio de edades menor.

            float  promedioMañana, promedioTarde, promedioNoche;
            float edadesMañama= 0, edadesTarde = 0, edadesNoche = 0;

            for (int i = 1; i <=20; i++) { 
             Console.WriteLine("ingrese edad de estudiante de la mañana");
                edadesMañama += float.Parse(Console.ReadLine());
            }
            promedioMañana = (edadesMañama / 20);

            for (int i = 1; i <= 30; i++)
            {
                Console.WriteLine("ingrese edad de estudiante de la tarde");
                edadesTarde += float.Parse(Console.ReadLine());
            }
            promedioTarde = (edadesTarde / 30);

            for (int i = 1; i <= 15; i++)
            {
                Console.WriteLine("ingrese edad de estudiante de la noche");
                edadesNoche += float.Parse(Console.ReadLine());
            }
            promedioNoche = (edadesNoche / 15);


            Console.WriteLine("Promedio mañana:"+promedioMañana);
            Console.WriteLine("Promedio tarde:" + promedioTarde);
            Console.WriteLine("Promedio noche:" + promedioNoche);
            
            if (promedioMañana < promedioTarde && promedioMañana < promedioNoche) { Console.WriteLine("El promedio de edades menor es el de la mañana"); }
            if (promedioMañana > promedioTarde && promedioTarde < promedioNoche) { Console.WriteLine("El promedio de edades menor es el de la tarde"); }
            if (promedioNoche < promedioTarde && promedioMañana > promedioNoche) { Console.WriteLine("El promedio de edades menor es el de la noche"); }


            Console.ReadKey();
        }
    }
}
