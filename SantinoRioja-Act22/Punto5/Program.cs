using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto5
{/*Actividad 5: Gestión de Carreras Deportivas
Consigna:
Crear un sistema para gestionar carreras deportivas. Cada carrera tiene un código,
una hora de inicio y una hora de fin. Cada carrera puede registrar varios corredores.
Se pide:
1. Crear una clase Carrera con:
o Atributos: código, hora de inicio, hora de fin y lista de corredores ya
definidos.
o Dos constructores (uno por defecto y otro con parámetros).
o Método para calcular la duración de la carrera usando TimeSpan.
2. Crear una clase Corredor con:
o Atributos: nombre, número de dorsal y tiempo total.
o Sobrecarga de métodos para registrar el tiempo total (en minutos o en
horas y minutos).

3. Mostrar en consola (usando Console.SetCursorPosition()):
o La carrera con mayor duración.
o El corredor más rápido.
4. Utilizar this en los constructores o métodos donde corresponda.*/
    class Carrera
    {
        int codigo;
        DateTime horaInicio;
        DateTime horaFin;
        List<Corredor> corredores;

        public Carrera()
        {
            corredores = new List<Corredor>();
        }

        public Carrera(int codigo, DateTime horaInicio, DateTime horaFin)
        {
            this.codigo = codigo;
            this.horaInicio = horaInicio;
            this.horaFin = horaFin;
            corredores = new List<Corredor>();
        }

        public TimeSpan Duracion()
        {
            return horaFin - horaInicio;
        }

        public void AgregarCorredor(Corredor corredor)
        {
            corredores.Add(corredor);
        }

        public int Codigo
        {
            get { return codigo; }
        }

        public List<Corredor> Corredores
        {
            get { return corredores; }
        }
    }

    class Corredor
    {
        string nombre;
        int numeroDorsal;
        TimeSpan tiempoTotal;

        public Corredor(string nombre, int numeroDorsal)
        {
            this.nombre = nombre;
            this.numeroDorsal = numeroDorsal;
        }

        public void RegistrarTiempo(int horas, int minutos)
        {
            tiempoTotal = new TimeSpan(horas, minutos, 0);
        }

        public void RegistrarTiempo(int minutos)
        {
            tiempoTotal = new TimeSpan(0, minutos, 0);
        }

        public string Nombre
        {
            get { return nombre; }
        }

        public int NumeroDorsal
        {
            get { return numeroDorsal; }
        }

        public TimeSpan TiempoTotal
        {
            get { return tiempoTotal; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Carrera[] carreras = new Carrera[2];

            carreras[0] = new Carrera(101,
                new DateTime(2025, 1, 1, 8, 0, 0),
                new DateTime(2025, 1, 1, 10, 30, 0));

            carreras[1] = new Carrera(102,
                new DateTime(2025, 1, 1, 9, 0, 0),
                new DateTime(2025, 1, 1, 11, 0, 0));

            Corredor c1 = new Corredor("Juan", 1);
            c1.RegistrarTiempo(1, 45);

            Corredor c2 = new Corredor("Ana", 2);
            c2.RegistrarTiempo(95);

            Corredor c3 = new Corredor("Pedro", 3);
            c3.RegistrarTiempo(2, 5);

            carreras[0].AgregarCorredor(c1);
            carreras[0].AgregarCorredor(c2);
            carreras[1].AgregarCorredor(c3);

            Carrera carreraMayor = carreras[0];

            foreach (Carrera m in carreras)
            {
                if (m.Duracion() > carreraMayor.Duracion())
                {
                    carreraMayor = m;
                }
            }

            Corredor corredorRapido = carreras[0].Corredores[0];

            foreach (Carrera m in carreras)
            {
                foreach (Corredor corredor in m.Corredores)
                {
                    if (corredor.TiempoTotal < corredorRapido.TiempoTotal)
                    {
                        corredorRapido = corredor;
                    }
                }
            }

            Console.SetCursorPosition(25, 12);
            Console.WriteLine("Código de carrera con mayor duracion: " + carreraMayor.Codigo+ " Su Duración: " + carreraMayor.Duracion());
            Console.WriteLine();

            Console.SetCursorPosition(25, 20);
            Console.WriteLine("El corredor mas rapido es: Nombre: " + corredorRapido.Nombre+ " Dorsal: " + corredorRapido.NumeroDorsal + " Tiempo: " + corredorRapido.TiempoTotal);

            Console.ReadKey();
        }
    }
}
