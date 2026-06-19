using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
/*1. Plantear una clase parcial ReservaHotel.
En el primer archivo, definir las propiedades NombreCliente, CantidadNoches y
TipoHabitacion (puede ser “Simple”, “Doble” o “Suite”), validando que la cantidad de
noches sea mayor a 0. Estos valores son cargados desde la consola.
En el segundo archivo, agregar un método que calcule el total a pagar según la
habitación elegida (por ejemplo: Simple = $5000, Doble = $8000, Suite = $12000 por
noche).
Desde la clase principal, cargar 3 reservas y mostrar cuál cliente pagará más.*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ReservaHotel reservaHotel1 = new ReservaHotel();
            ReservaHotel reservaHotel2 = new ReservaHotel();
            ReservaHotel reservaHotel3 = new ReservaHotel();
            Console.WriteLine("Reseva 1 total:"+reservaHotel1.TotalPagar());
            Console.WriteLine("Reseva 2 total:" + reservaHotel2.TotalPagar());
            Console.WriteLine("Reseva 3 total:" + reservaHotel3.TotalPagar());
            if (reservaHotel1.TotalPagar()> reservaHotel2.TotalPagar()&& reservaHotel1.TotalPagar() > reservaHotel2.TotalPagar())
            {
                Console.WriteLine("El cliente que mas pagara es"+ reservaHotel1.NombreCliente);
            }
            if (reservaHotel1.TotalPagar() < reservaHotel2.TotalPagar() && reservaHotel2.TotalPagar() > reservaHotel2.TotalPagar())
            {
                Console.WriteLine("El cliente que mas pagara es" + reservaHotel2.NombreCliente);
            }
            if (reservaHotel3.TotalPagar() > reservaHotel2.TotalPagar() && reservaHotel1.TotalPagar() < reservaHotel2.TotalPagar())
            {
                Console.WriteLine("El cliente que mas pagara es " + reservaHotel3.NombreCliente);
            }
            Console.ReadKey();
        }
    }
}
