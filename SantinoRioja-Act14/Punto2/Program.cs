using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
/*2. Control de Vuelos
Plantear una clase llamada Pasajero que tenga los atributos privados: Nombre, DNI y EquipajeKilos (peso del equipaje en kg).
En su constructor, solicitar la carga de estos tres datos.
Luego, confeccionar una clase llamada Vuelo que administre un vector de 4 objetos de la clase Pasajero.
Su constructor debe inicializar el vector y solicitar la carga por teclado de cada uno de los 4 pasajeros.
Agregar los siguientes métodos en la clase Vuelo:
Un método que muestre un listado completo con los datos de todos los pasajeros del vuelo.
Un método que calcule y muestre el peso total de equipaje que transporta el avión (la suma de todos los pesos).
Un método que informe si algún pasajero excede el límite permitido de equipaje (mayor a 23 kg), imprimiendo su nombre y su DNI.
*/
{
    class Pasajero
    {
        private string Nombre;
        private int DNI;
        private float EquipajeKilos;
        public Pasajero()
        {
            Console.WriteLine("Ingrese el nombre del pasajero");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el DNI del pasajero");
            DNI = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el peso del equipaje en kg");
            EquipajeKilos = float.Parse(Console.ReadLine());
        }
        internal class Vuelo
        {
            private Pasajero[] pasajeros;
            public Vuelo() {
                pasajeros = new Pasajero[4];
                for (int i = 0; i < pasajeros.Length; i++)
                {
                    pasajeros[i] = new Pasajero();
                }
            }
            public void MostrarPasajeros()
            {
                for (int i = 0; i < pasajeros.Length; i++)
                {
                    Console.WriteLine("Pasajero: " + pasajeros[i].Nombre + ", DNI: " + pasajeros[i].DNI + ", Equipaje: " + pasajeros[i].EquipajeKilos + " kg");
                }
            }
            public void CalcularPesoTotal()
            {
                float pesoTotal = 0;
                for (int i = 0; i < pasajeros.Length; i++)
                {
                    pesoTotal += pasajeros[i].EquipajeKilos;
                }
                Console.WriteLine("Peso total del equipaje: " + pesoTotal + " kg");
            }
            public void VerificarEquipajeExcedido()
            {
                for (int i = 0; i < pasajeros.Length; i++)
                {
                    if (pasajeros[i].EquipajeKilos > 23)
                    {
                        Console.WriteLine("Pasajero: " + pasajeros[i].Nombre + ", DNI: " + pasajeros[i].DNI + " excede el límite de equipaje permitido.");
                    }
                }
            }
            static void Main(string[] args)
            {
                Vuelo vuelo1=new Vuelo();
                vuelo1.MostrarPasajeros();
                vuelo1.CalcularPesoTotal();
                vuelo1.VerificarEquipajeExcedido();
                Console.ReadKey();
            }
        }
    }
}