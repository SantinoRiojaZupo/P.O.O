using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Carrera
        //3. Se registran los nombres de 5 atletas y sus tiempos (en segundos) en una carrera de 100 metros.
        //El programa debe cargar los datos en dos vectores paralelos,
        //calcular y mostrar el promedio de los tiempos,
        //mostrar el nombre del atleta con mejor y peor tiempo,
        //y mostrar los nombres de quienes superaron el promedio.
    {
        private string[] atletas;
        private float[] tiempos;
        private float mejorTiempo, peorTiempo,promedio;

        public void cargar() {
            atletas= new string[5];
            tiempos= new float[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese nombre de atleta N°" +(i+1));
                atletas[i]=Console.ReadLine();
                Console.WriteLine("Ingrese su tiempo en segundos(Use comas no puntos)");
                tiempos[i]=float.Parse(Console.ReadLine());
            }
            }
        public void cargarPromedio()
        {
            for (int i = 0; i < 5; i++) {
                promedio += tiempos[i];
            }
            promedio = promedio / 5;
            Console.WriteLine("El promedio de los tiempos es de: "+ promedio);
        }
        public void peoresMejores()
        {
            mejorTiempo = tiempos[0];
            peorTiempo = tiempos[0];
            for (int i = 1; i < 5; i++) {
                if (mejorTiempo > tiempos[i]) {
                    mejorTiempo = tiempos[i];
                }
                if (peorTiempo < tiempos[i]) {
                peorTiempo= tiempos[i];
                }
            }
            for (int i = 0; i < 5; i++) {
                if (mejorTiempo == tiempos[i]) {
                    Console.WriteLine("Atleta con mejor tiempo: "+ atletas[i]+ " Tiempo:"+tiempos[i]);
                }
                if (peorTiempo == tiempos[i])
                {
                    Console.WriteLine("Atleta con peor tiempo: " + atletas[i] + " Tiempo:" + tiempos[i]);
                }
            }
        }
        public void mayorPromedio()
        {
            Console.WriteLine("Atletas que superaron el promedio:");
            for (int i = 0; i < 5; i++)
            {
                if (tiempos[i] < promedio) {
                    Console.WriteLine(atletas[i]+ " Tiempo:" + tiempos[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            Carrera carrera1 = new Carrera();
            carrera1.cargar();
            carrera1.cargarPromedio();
            carrera1.peoresMejores();
            carrera1.mayorPromedio();
            Console.ReadKey();
        }
    }
}
