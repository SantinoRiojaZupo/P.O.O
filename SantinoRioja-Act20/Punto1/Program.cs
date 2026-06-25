using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    /*Actividad 1: Sistema de control de vuelos
Problema:
Una aerolínea administra los vuelos programados mediante un sistema orientado a objetos.
Plantear una clase base Vuelo que contenga como propiedades: número de vuelo,
destino y duración en horas. Luego definir una clase derivada VueloInternacional que
herede de Vuelo e incluya una propiedad adicional llamada paisDestino.
Crear una lista de objetos de tipo VueloInternacional, cargar 5 vuelos con sus datos
desde consola y luego:
 Mostrar los vuelos registrados y el país de destino.
 Informar cuál es el vuelo con mayor duración.
 Mostrar el orden de ejecución de los constructores.*/

    class Vuelo
    {
        protected int numeroDeVuelo;
        protected string destino;
        protected float duracionHoras;
        public Vuelo()
        {
            Console.WriteLine("--Clase Actual: Vuelo --");
            Console.WriteLine("Ingrese la duracion en horas del vuelo");
            duracionHoras = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero del vuelo");
            numeroDeVuelo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el destino del vuelo");
            destino = Console.ReadLine();
        }

        public float DuracionHoras {  get { return duracionHoras; } set { duracionHoras = value; } }
        public int NumeroDeVuelo { get { return numeroDeVuelo; } set { numeroDeVuelo = value; } }
        public string Destino { get { return destino; } set { destino = value; } }

    }
    class VueloInternacional : Vuelo
    {
        protected string paisDestino;
        public VueloInternacional() {
            Console.WriteLine("--Clase Actual: VueloInternacional --");
            Console.WriteLine("Ingrese el pais de destino del vuelo");
            paisDestino = Console.ReadLine();
        }
        public string PaisDestino { get { return paisDestino; } set { paisDestino = value; } }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            float masLargo =0;
            List<VueloInternacional> vuelosInternacionales = new List<VueloInternacional>();
            for (int i = 0;i<2;i++)
            {
               VueloInternacional vueloInt = new VueloInternacional();
                if (vueloInt.NumeroDeVuelo > masLargo){
                    masLargo = vueloInt.NumeroDeVuelo;
                }
                vuelosInternacionales.Add(vueloInt);
            }
            foreach (VueloInternacional m in vuelosInternacionales)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Numero del vuelo:"+m.NumeroDeVuelo);
                Console.WriteLine("Destino del vuelo:" + m.Destino);
                Console.WriteLine("Duracion del vuelo:" + m.DuracionHoras);
                Console.WriteLine("Destino pais del vuelo:" + m.Destino);
                Console.WriteLine("------------------------------------");
                if (m.DuracionHoras==masLargo)
                {
                    Console.WriteLine("El vuelo mas largo es el numero "+ m.NumeroDeVuelo);
                }
            }
            Console.ReadKey();
        }
    }
}
