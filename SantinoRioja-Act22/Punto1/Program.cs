using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
        /*Actividad 1: Control de horarios en un gimnasio
Problema:
Crear una clase ClaseGimnasio con atributos: nombreClase, horaInicio y horaFin (usar
DateTime).
 Implementar un constructor que permita cargar los datos desde consola y otro
que cargue valores por defecto (sobrecarga de constructores).
 Incluir un método para calcular la duración de la clase usando TimeSpan.
 Crear un vector de 3 clases de gimnasio y mostrar:
1. La clase que tenga la mayor duración.
2. El nombre y el horario de inicio de la clase más temprana.*/
    class ClaseGimnasio
    {
        string nombreClase;
        DateTime horaInicio, horaFin;
        double horasTotal;
        public ClaseGimnasio()
        {
            int hora;
            Console.WriteLine("ingrse el nombre de la clase");
            nombreClase = Console.ReadLine();
            Console.WriteLine("Ingrese la hora de inicio de la clase");
            hora = int.Parse(Console.ReadLine());
            DateTime horaInicio = new DateTime(1, 1, 1, hora,0,0);
            Console.WriteLine("Ingrese la hora del fin de la clase");
            hora = int.Parse(Console.ReadLine());
            DateTime horaFin = new DateTime(1, 1, 1, hora, 0, 0);
            TimeSpan diferencia = horaFin - horaInicio;
            horasTotal = diferencia.TotalHours;
            Console.WriteLine(horasTotal);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ClaseGimnasio[] clasesGimnasio= new ClaseGimnasio[3];
            clasesGimnasio[0] = new ClaseGimnasio();
            
            Console.ReadKey();
        }
    }
}
