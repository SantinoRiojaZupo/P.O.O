using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
/*3. Competencia de Atletismo
Plantear una clase llamada Atleta que tenga como atributos privados el Nombre y el TiempoSegundos (tiempo que tardó en completar una carrera).
Definir un constructor para ingresar ambos datos.
Luego, crear una clase llamada Carrera que administre 3 objetos de la clase Atleta como atributos de la clase.
Definir los siguientes métodos en la clase Carrera:
Un constructor que cargue los datos de los 3 atletas de la carrera.
Un método que imprima los nombres de los atletas junto con sus marcas de tiempo.
Un método que calcule e imprima el tiempo promedio de la carrera.
Un método que informe el nombre del atleta ganador de la carrera (aquel que completó la prueba en el menor tiempo).
Un método que muestre a los atletas que superaron el promedio.
*/
{
    class Atleta
    {
        private string Nombre;
        private float TiempoSegundos;
        public Atleta()
        {
            Console.WriteLine("Ingrese el nombre del atleta:");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el tiempo del atleta en segundos:");
            TiempoSegundos = float.Parse(Console.ReadLine());
        }
        public string DevolverNombre()
        {
            return Nombre;
        }
        public float DevolverTiempo()
        {
            return TiempoSegundos;
        }

    }
    internal class Carrera
    {
        private Atleta atleta1, atleta2, atleta3;

        public Carrera()
        {
             atleta1 = new Atleta();
             atleta2 = new Atleta();
             atleta3 = new Atleta();
        }
        public void ImprimirAtletas()
        {
            Console.WriteLine("Atleta 1: " + atleta1.DevolverNombre() + "  Tiempo: " + atleta1.DevolverTiempo() + " segundos");
            Console.WriteLine("Atleta 2: " + atleta2.DevolverNombre() + "  Tiempo: " + atleta2.DevolverTiempo() + " segundos");
            Console.WriteLine("Atleta 3: " + atleta3.DevolverNombre() + "  Tiempo: " + atleta3.DevolverTiempo() + " segundos");
        }
        public void CalcularPromedio()
        {
            float promedio = (atleta1.DevolverTiempo() + atleta2.DevolverTiempo() + atleta3.DevolverTiempo()) / 3;
            Console.WriteLine("El tiempo promedio de la carrera es: " + promedio + " segundos");
       
        }
        public void AtletaGanador()
            {
            string ganadorNombre = atleta1.DevolverNombre();
            float ganadorTiempo = atleta1.DevolverTiempo();
            if (atleta2.DevolverTiempo() < ganadorTiempo)
            {
                ganadorNombre = atleta2.DevolverNombre();
                ganadorTiempo = atleta2.DevolverTiempo();
            }
            if ( atleta3.DevolverTiempo()<ganadorTiempo)
            {
                ganadorNombre = atleta3.DevolverNombre();
                ganadorTiempo = atleta3.DevolverTiempo();
            }
            Console.WriteLine("El atleta ganador es:" + ganadorNombre);
        }
        public void AtletasSuperaronPromedio()
        {
            float promedio = (atleta1.DevolverTiempo() + atleta2.DevolverTiempo() + atleta3.DevolverTiempo()) / 3;
            Console.WriteLine("Atletas que superaron el promedio:");
            if (atleta1.DevolverTiempo() < promedio)
            {
                Console.WriteLine(atleta1.DevolverNombre());
            }
            if (atleta2.DevolverTiempo() < promedio)
            {
                Console.WriteLine(atleta2.DevolverNombre());
            }
            if (atleta3.DevolverTiempo() < promedio)
            {
                Console.WriteLine(atleta3.DevolverNombre());
            }
        }
        static void Main(string[] args)
        {
            Carrera carrera1 = new Carrera();
            carrera1.ImprimirAtletas();
            carrera1.CalcularPromedio();
            carrera1.AtletaGanador();
            carrera1.AtletasSuperaronPromedio();
            Console.ReadKey();
        }
    }
}