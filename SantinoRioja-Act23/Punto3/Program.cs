using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    /*3-
Un centro de conservación marina registra de forma dinámica las especies de
mamíferos marinos divisadas en la costa para su posterior análisis estadístico.

 Crear la clase MonitoreoCostero que contenga como atributo privado
una lista de cadenas de texto List<string> especiesDetectadas.
 Métodos en MonitoreoCostero:
1. CargarAvistamientos(): Solicitar por teclado nombres de
especies marinas avistadas (ej: Ballena Franca,   Lobo Marino,
Delfín) y agregarlos a la lista utilizando .Add(). La carga finaliza
cuando el usuario ingresa la palabra FIN.

2. MostrarReporteOrdenado(): Imprimir la lista de avistamientos
organizada alfabéticamente de la A a la Z utilizando el método
.Sort().

3. MostrarReporteInvertido(): Imprimir la lista organizada de la
Z a la A combinando .Sort() con el método .Reverse().

4. BuscarEspecie(): Pedir al operador que ingrese el nombre de un
animal y, utilizando los métodos de búsqueda de listas, informar si la
especie fue divisada en la costa durante el día.*/
    class MonitoreoCostero
    {

        List<string> especiesDetectadas = new List<string> { };
        public void CargarAvistamientos()
        {
            string especieAvistada;
            bool programa = true;
            while (programa == true)
            {
                Console.WriteLine("Ingrese nombres de especies marinas avistadas, cuando termine escriba FIN");
                especieAvistada = Console.ReadLine();
                if (especieAvistada == "FIN")
                {
                    programa = false;
                }
                else { 
                especiesDetectadas.Add(especieAvistada);
                }
            }
        }
        public void MostrarReporteOrdenado()
        {
            especiesDetectadas.Sort();
            Console.WriteLine("Lista de avistamientos ordenada");
            foreach (string s in especiesDetectadas) { Console.WriteLine(s); }
        }
        public void MostrarReporteInvertido()
        {
            especiesDetectadas.Reverse();
            Console.WriteLine("Lista de avistamientos ordenada de forma invertida");
            foreach (string s in especiesDetectadas) { Console.WriteLine(s); }
        }
        public void BuscarEspecie()
        {
            bool avistado = false;
            string animalBuscado;
            Console.WriteLine("Ingrese el nombre de un animal");
            animalBuscado = Console.ReadLine();
            foreach (string s in especiesDetectadas)
            {
                if (s == animalBuscado)
                {
                    avistado = true;
                }

            }
            if (avistado == true)
            {
                Console.WriteLine("La especie fue avistada durante el dia");
            }
            else { Console.WriteLine("La especie no fue avistada durante el dia"); }
        }

    }
    internal class Program
    {

        static void Main(string[] args)
        {
            MonitoreoCostero monitoreoCostero1 = new MonitoreoCostero();
            monitoreoCostero1.CargarAvistamientos();
            monitoreoCostero1.MostrarReporteOrdenado();
            monitoreoCostero1.MostrarReporteInvertido();
            monitoreoCostero1.BuscarEspecie();
            Console.ReadKey();
        }
    }
}
