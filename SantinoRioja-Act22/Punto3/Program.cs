using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{/*Actividad 3: Registro de entrenamientos
Problema:
Plantear una clase Entrenamiento con atributos: deportista y duración (en minutos).
 Incluir dos métodos RegistrarDuracion (sobrecarga de métodos):
1. Uno que reciba horas y minutos y los convierta a minutos.
2. Otro que reciba directamente los minutos.
 Crear una lista con 5 entrenamientos y mostrar el entrenamiento más largo y el
más corto.*/
    class Entrenamiento
    {
        string deportista;
        int duracion;
        public Entrenamiento(string deportista)
        {
            this.deportista = deportista;

        }
        public void RegistrarDuracion(int horas, int minutos)
        {
            this.duracion = (horas * 60) + minutos;
        }
        public void RegistrarDuracion(int minutos)
        {
            this.duracion = minutos;
        }
        public string Deportista
        {
            set { deportista = value; }
            get { return deportista; }
        }
        public int Duracion
        {
            set { duracion = value; }
            get { return duracion; }
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Entrenamiento> entrenamientos = new List<Entrenamiento>();
            entrenamientos.Add(new Entrenamiento("Santi"));
            entrenamientos.Add(new Entrenamiento("pepe"));
            entrenamientos.Add(new Entrenamiento("emiliano"));
            entrenamientos.Add(new Entrenamiento("benja"));
            entrenamientos.Add(new Entrenamiento("thiago"));
            entrenamientos[0].RegistrarDuracion(1, 30);
            entrenamientos[1].RegistrarDuracion(130);
            entrenamientos[2].RegistrarDuracion(1, 60);
            entrenamientos[3].RegistrarDuracion(333);
            entrenamientos[4].RegistrarDuracion(2, 0);

            int masLargo=0;
            int masCorto = entrenamientos[0].Duracion;
            foreach (Entrenamiento m in entrenamientos)
            {
                if (m.Duracion > masLargo) { masLargo = m.Duracion; }

                if (m.Duracion < masCorto) { masCorto = m.Duracion; }
            }
            foreach(Entrenamiento m in entrenamientos)
            {
               if (m.Duracion == masLargo) { Console.WriteLine("El entrenamiento mas largo es el del deportista:"+m.Deportista+" Con una duracion de "+m.Duracion+" minutos"); }
                if (m.Duracion == masCorto) { Console.WriteLine("El entrenamiento mas corto es el del deportista:" + m.Deportista + " Con una duracion de " + m.Duracion + " minutos"); }

            }

            Console.ReadKey();
        }
    }
}
