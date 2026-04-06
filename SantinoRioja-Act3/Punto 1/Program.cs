using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Realizar un programa que pida cargar una fecha cualquiera, luego verificar si dicha fecha corresponde a Navidad.
            DateTime fecha;
            Console.WriteLine("escribi fecha: dia(00)/mes(00)/año(0000)");
            fecha = DateTime.Parse(Console.ReadLine());
            Console.Write(fecha);
            if (fecha.Day == 25 && fecha.Month == 12)
            {
                Console.WriteLine(" es navidad");
            }
            else
            {
                Console.WriteLine(" no es navidad");
            }

            Console.ReadKey();
        }
    }
}
