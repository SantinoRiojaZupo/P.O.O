using System;

namespace Punto4
{
    internal class Program
        /*Actividad 4: Gestión de vuelos
Problema:

Definir una clase Vuelo con atributos: codigo, horaSalida y horaLlegada (DateTime).
 Usar la palabra clave this en el constructor para diferenciar los parámetros de
los atributos.
 Crear un método para calcular la duración del vuelo (TimeSpan).
 Cargar un vector con 4 vuelos y mostrar:
1. El código y duración del vuelo más largo.
2. El código del vuelo que salga más temprano.*/
    {
        class Vuelo
        {
            int codigo;
            DateTime horaSalida;
            DateTime horaLlegada;
            TimeSpan duracion;
            public Vuelo(int codigo, DateTime horaSalida, DateTime horaLlegada)
            {
                this.codigo = codigo;
                this.horaSalida = horaSalida;
                this.horaLlegada = horaLlegada;
            }
            public void DuracionVuelo()
            {
                duracion = horaLlegada - horaSalida;
            }

            public int Codigo
            {
                get { return codigo; }
                set { codigo = value; }
            }

            public DateTime HoraSalida
            {
                get { return horaSalida; }
                set { horaSalida = value; }
            }

            public DateTime HoraLlegada
            {
                get { return horaLlegada; }
                set { horaLlegada = value; }
            }

            public TimeSpan Duracion
            {
                get { return duracion; }
            }
        }
   static void Main(string[] args)
        {
            Vuelo[] vuelos = new Vuelo[4];

            for (int i = 0; i < vuelos.Length; i++)
            {
                Console.WriteLine("Vuelo " + (i));

                Console.Write("Escriba codigo de vuelo: ");
                int codigo = int.Parse(Console.ReadLine());

                Console.Write("Escriba Hora de salida (yyyy-MM-dd HH:mm): ");
                DateTime horaSalida = DateTime.Parse(Console.ReadLine());

                Console.Write("Escriba Hora de llegada (yyyy-MM-dd HH:mm): ");
                DateTime horaLlegada = DateTime.Parse(Console.ReadLine());

                vuelos[i] = new Vuelo(codigo, horaSalida, horaLlegada);
                vuelos[i].DuracionVuelo();
            }
            Vuelo vueloMasLargo = vuelos[0];
            Vuelo vueloMasTemprano = vuelos[0];

            for (int i = 1; i < vuelos.Length; i++)
            {
                if (vuelos[i].Duracion > vueloMasLargo.Duracion)
                {
                    vueloMasLargo = vuelos[i];
                }

                if (vuelos[i].HoraSalida < vueloMasTemprano.HoraSalida)
                {
                    vueloMasTemprano = vuelos[i];
                }
            }
            Console.WriteLine("El vuelo mas largo tiene el codigo:"+vueloMasLargo.Codigo+ " Y dura:"+vueloMasLargo.Duracion);

            Console.WriteLine("El vuelo mas temprano tiene el codigo:" + vueloMasTemprano.Codigo);

            Console.ReadKey();
        }
    }
}