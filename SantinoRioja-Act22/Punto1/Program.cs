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
            this.nombreClase = Console.ReadLine();
            Console.WriteLine("Ingrese la hora de inicio de la clase");
            hora = int.Parse(Console.ReadLine());
            DateTime horaInicio = new DateTime(1, 1, 1, hora, 0, 0);
            Console.WriteLine("Ingrese la hora del fin de la clase");
            hora = int.Parse(Console.ReadLine());
            DateTime horaFin = new DateTime(1, 1, 1, hora, 0, 0);
            this.horaInicio = horaInicio;
            this.horaFin = horaFin;
            GetDuracion(this.horaInicio,this.horaFin);
        }
        public ClaseGimnasio(string nombreClase, DateTime horaInicio, DateTime horaFin)
        {
            this.nombreClase = nombreClase;
            this.horaInicio = horaInicio;
            this.horaFin = horaFin;

           
            GetDuracion(this.horaInicio, this.horaFin);
        }
        public double GetDuracion(DateTime horaInicio, DateTime horaFin)
        {
            TimeSpan diferencia = horaFin - horaInicio;
            horasTotal = diferencia.TotalHours;
            Console.WriteLine("La clase " + nombreClase + " tiene una duración de " + horasTotal + " horas.");
            return horasTotal;
        }
        public DateTime HoraInicio
        {
            set { horaInicio = value; }
            get { return horaInicio; }
        }
    internal class Program
    {
        static void Main(string[] args)
        {
            ClaseGimnasio[] clasesGimnasio= new ClaseGimnasio[3];
            clasesGimnasio[0] = new ClaseGimnasio();
                clasesGimnasio[1] = new ClaseGimnasio("Yoga", new DateTime(1, 1, 1, 8, 0, 0), new DateTime(1, 1, 1, 9, 0, 0));
                clasesGimnasio[2] = new ClaseGimnasio();

                double masDuradera = clasesGimnasio[0].horasTotal;
                DateTime masTemprana = clasesGimnasio[0].HoraInicio;
                for(int i=1; i < clasesGimnasio.Length;i++)
                {

                    if (clasesGimnasio[i].HoraInicio < masTemprana)
                    {
                        masTemprana = clasesGimnasio[i].HoraInicio;
                    }

                    if (clasesGimnasio[i].horasTotal>masDuradera)
                    {
                        masDuradera = clasesGimnasio[i].horasTotal;
                    }
                }
                for (int i = 0; i<clasesGimnasio.Length;i++)
                {
                    if (clasesGimnasio[i].horasTotal==masDuradera)
                    {
                        Console.WriteLine("La clase con mas duracion es la clase: " + clasesGimnasio[i].nombreClase);
                    }
                    if (clasesGimnasio[i].HoraInicio== masTemprana)
                    {
                        int horaTemprana = clasesGimnasio[i].HoraInicio.TimeOfDay.Hours;
                        Console.WriteLine("La clase mas temprana es la clase :" + clasesGimnasio[i].nombreClase+ " Que inicia a las:" + horaTemprana+ " horas");
                    }
                }
                Console.ReadKey();
        }
    }
}}
