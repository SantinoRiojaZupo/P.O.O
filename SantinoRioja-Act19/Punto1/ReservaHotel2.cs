using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    partial class ReservaHotel
    {
        public int TotalPagar()
        {

            int total = 0;
            if (TipoHabitacion=="Simple")
            {
                total=5000*CantidadNoches;
                return total;
            }
            if (TipoHabitacion == "Doble")
            {
                total = 8000 * CantidadNoches;
                return total;
            }
            if (TipoHabitacion == "Suite")
            {
                total = 12000 * CantidadNoches;
                return total;
            }
            else { Console.WriteLine("No ingreso bien el tipo de habitacion:"+TipoHabitacion);
            return total;}

        }
    }
}
