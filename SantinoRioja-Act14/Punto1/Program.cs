using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    /*1. El Sistema de Peaje.
Plantear una clase llamada Vehiculo y otra clase llamada CabinaPeaje.
La clase Vehiculo debe tener los siguientes atributos privados:
Patente (de tipo string).
Tipo (puede ser "Auto", "Camion" o "Moto").
Tarifa (un valor decimal que representa el costo de su pase).
El constructor de Vehiculo debe solicitar y cargar estos tres datos por teclado.
La clase CabinaPeaje debe tener como atributos privados:
El número o identificador de la cabina.
Tres objetos de la clase Vehiculo (que representan los últimos 3 vehículos que pagaron en esa cabina).
Definir en la clase CabinaPeaje un constructor para inicializar su identificador y solicitar la carga de los 3 vehículos. Además, implementar los siguientes métodos dentro de CabinaPeaje:
Un método que imprima la patente y el tipo de los 3 vehículos registrados en la cabina.
Un método que calcule y muestre la recaudación total acumulada por esos 3 vehículos.
Un método que muestre la patente del vehículo que pagó la tarifa más cara.
*/
    class Vehiculo
    {
        private string Patente, Tipo;
        private float tarifa;
        public Vehiculo()
        {
            Console.WriteLine("Ingrese la patente");
            Patente = Console.ReadLine();
            Console.WriteLine("Ingrese el tipo de del vehiculo:Auto, Camion o Moto");
            Tipo = Console.ReadLine();
            Console.WriteLine("Ingrese la tarifa a pagar");
            tarifa = float.Parse(Console.ReadLine());
        }
        public string devolverPatente()
        {
            return Patente;
        }

        public string devolverTipo()
        {
            return Tipo;
        }
        public float devolverTarifa()
        {
            return tarifa;
        }
        internal class CabinaPeaje
        {
            private CabinaPeaje cabinaPeaje1, cabinaPeaje2, cabinaPeaje3;
            private int cabina;
            private Vehiculo vehiculo1, vehiculo2, vehiculo3;
            public CabinaPeaje()
            {
                Console.WriteLine("Ingrese el identificador de la cabina");
                cabina = int.Parse(Console.ReadLine());
                vehiculo1 = new Vehiculo();
                vehiculo2 = new Vehiculo();
                vehiculo3 = new Vehiculo();
            }
            public void impPatenteTipo()
            {
                Console.WriteLine("Patente:" + vehiculo1.devolverPatente() + " Tipo:" + vehiculo1.devolverTipo() +" Cabina:"+ cabina);
                Console.WriteLine("Patente:" + vehiculo2.devolverPatente() + " Tipo:" + vehiculo2.devolverTipo() + " Cabina:" + cabina);
                Console.WriteLine("Patente:" + vehiculo3.devolverPatente() + " Tipo:" + vehiculo3.devolverTipo() + " Cabina:" + cabina);
            }
            public void recTotal()
            {
                float total = 0;
                total += (vehiculo1.devolverTarifa() + vehiculo2.devolverTarifa() + vehiculo3.devolverTarifa());
                Console.WriteLine("Total recaudado:" + total);
            }
            public void masCara()
            {
                float tarCaro = vehiculo1.devolverTarifa();
                string patCaro = vehiculo1.devolverPatente();
                if (tarCaro < vehiculo2.devolverTarifa())
                {
                    tarCaro=vehiculo2.devolverTarifa();
                    patCaro = vehiculo2.devolverPatente();
                }
                if (tarCaro < vehiculo3.devolverTarifa())
                {
                    tarCaro = vehiculo3.devolverTarifa();
                    patCaro = vehiculo3.devolverPatente();
                }
                Console.WriteLine("La patente del vehiculo que pago la tarifa mas cara:"+ patCaro);

            }
            static void Main(string[] args)
            {
             CabinaPeaje   cabinaPeaje1 = new CabinaPeaje();
                CabinaPeaje cabinaPeaje2 = new CabinaPeaje();
                CabinaPeaje cabinaPeaje3 = new CabinaPeaje();
                cabinaPeaje1.impPatenteTipo();
                cabinaPeaje1.recTotal();
                cabinaPeaje1.masCara();
                cabinaPeaje2.impPatenteTipo();
                cabinaPeaje2.recTotal();
                cabinaPeaje2.masCara();
                cabinaPeaje3.impPatenteTipo();
                cabinaPeaje3.recTotal();
                cabinaPeaje3.masCara();
                Console.ReadKey();
            }
        }
    }
}
