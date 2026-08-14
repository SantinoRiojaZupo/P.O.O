using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    /*10-
Un estacionamiento medido administra el ingreso y la salida de los vehículos que
utilizan su playa por orden de llegada.
 Crear la clase Ticket que contenga como atributos privados: patente
(string) y horasEstadia (int). Definir sus propiedades de solo lectura y un
constructor que reciba pat y hs.
 Crear la clase GestionEstacionamiento que administre una lista
dinámica de tickets (List).
 Métodos en GestionEstacionamiento:
o RegistrarIngreso(): Solicitar por teclado los datos de un ticket y
agregarlo al final de la lista utilizando .Add().
o ProcesarSalida(): Si la lista no está vacía, simular la salida del
primer vehículo de la lista (mostrar sus datos en consola) y
removerlo de la colección mediante .RemoveAt(0). Si está vacía,
advertir que no hay vehículos esperando salida.
o MostrarVehiculosEstacionados(): Listar todos los vehículos
alojados en la playa y la cantidad total de unidades presentes
utilizando la propiedad .Count.*/
    class Ticket
    {
        private string patente;
        private int horasEstadia;
        public string Patente
        {
            get { return patente; }
            set { patente = value; }
        }
        public int HorasEstadia
        {
            get { return horasEstadia; }
            set { horasEstadia = value; }
        }
        public Ticket(string pat, int hs)
        {
            patente = pat;
            horasEstadia = hs;
        }
    }
    class GestionEstacionamiento
    {
        List<Ticket>tickets = new List<Ticket>();
        public void RegistrarIngreso()
        {
            string pat;
            int hs=0;
            Console.WriteLine("Ingrese la patente");
            pat = Console.ReadLine();
            Console.WriteLine("ingrese las horas de estadia");
            hs = int.Parse(Console.ReadLine());
            tickets.Add(new Ticket(pat,hs));
        }
        public void ProcesarSalida()
        {
            if (tickets.Count != 0)
            {
                Console.WriteLine("Salida del primer vehiculo:");
                Console.WriteLine("Patente:" + tickets[0].Patente+"  Horas de estadia:" + tickets[0].HorasEstadia);
                tickets.RemoveAt(0);
            }
            else
            {
                Console.WriteLine("No hay vehiculos esperando una salida");
            }
        }
        public void MostrarVehiculosEstacionados()
        {
            Console.WriteLine("Vehiculos alojados en la playa");
            foreach (Ticket ticket in tickets)
            {
                Console.WriteLine("Patente:"+ticket.Patente+"   Horas de estadia:"+ticket.HorasEstadia);
            }
            Console.WriteLine("Unidades presentes:"+ tickets.Count);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            GestionEstacionamiento gestionEstacionamiento1 = new GestionEstacionamiento();
            gestionEstacionamiento1.RegistrarIngreso();
            gestionEstacionamiento1.RegistrarIngreso();
            gestionEstacionamiento1.RegistrarIngreso();
            gestionEstacionamiento1.ProcesarSalida();
            gestionEstacionamiento1.MostrarVehiculosEstacionados();
            Console.ReadKey();
        }
    }
}
