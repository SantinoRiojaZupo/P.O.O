using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    partial class ReservaHotel
    {
        protected string nombreCliente;
        protected int cantidadNoches;
        protected string tipoHabitacion;
        public ReservaHotel()
        {
            Console.WriteLine("Ingrese el nombre del cliente");
            nombreCliente = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad de noches mayor a 0");
            cantidadNoches= int.Parse(Console.ReadLine());
            while (cantidadNoches<=0)
            {
                Console.WriteLine("La cantidad de noches tiene que ser mayor a 0");
                cantidadNoches = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ingrese el tipo de habitacion:Simple||Doble||Suite");
            tipoHabitacion = Console.ReadLine();
        }
        public string NombreCliente
        {
            get { return nombreCliente; }
            set { nombreCliente = value; }
        }
        public int CantidadNoches
        {
            get { return cantidadNoches; }
            set { cantidadNoches = value; }
        }
        public string TipoHabitacion
        {
            get { return tipoHabitacion; }
            set { tipoHabitacion = value; }
        }
    }
}
