using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. En una empresa trabajan n empleados cuyos sueldos oscilan entre $100 y
            //$500, realizar un programa que lea los sueldos que cobra cada empleado e
            //informe cuántos empleados cobran entre $100 y $300 y cuántos cobran más
            //de $300.Además el programa deberá informar el importe que gasta la empresa
            //en sueldos al personal.
            int i = 6;
            int empleados_100_300 = 0;
            int empleados_mas_300 = 0;
            int sueldos = 0;
            int sueldo = 0;
            while (i>0) {
                Console.WriteLine("Ingrese un sueldo entre 100 y 500 para "+i +" empleados");
                sueldo= int.Parse(Console.ReadLine());
                if (sueldo < 100 || sueldo > 500) {
                    Console.WriteLine("Sueldo no valido, ingrese un sueldo entre $100 y $500");
                }
                if (sueldo>=100 && sueldo <= 500) { 
                    if (sueldo >= 100 && sueldo <= 300) {
                        empleados_100_300++;
                    }
                    else {
                        empleados_mas_300++;
                    }
                    sueldos += sueldo;
                    sueldo =0;
                    i--;
                }
                if (i==0)
                {
                    Console.WriteLine("Empleados que cobran entre $100 y $300: "+empleados_100_300);
                    Console.WriteLine("Empleados que cobran mas de $300: "+ empleados_mas_300);
                    Console.WriteLine("Importe total que gasta la empresa en sueldos: "+ sueldos);}
                
            }
            Console.ReadKey();
        }
    }
}
