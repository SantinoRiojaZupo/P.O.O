using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
    /*3. Plantear una clase Club y otra clase Socio.
La clase Socio debe tener los siguientes atributos privados: nombre y la antigüedad en el club (en años).
En el constructor pedir la carga del nombre y su antigüedad.
La clase Club debe tener como atributos 3 objetos de la clase Socio.
Definir una responsabilidad para imprimir el nombre del socio con mayor antigüedad en el club.*/
{
    class socios {
        private string nombre;
            private int antiguedad;
        public socios(){
            Console.WriteLine("Ingrese el nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese antiguedad del socio en el club");
            antiguedad = int.Parse(Console.ReadLine());
        }

        public string devolverNom() { 
            return nombre; 
        }
        public int devolverAnt()
        {
            return antiguedad;
        }
    }
    internal class Club
    { 
        private socios socio1, socio2, socio3;
        public Club() {
            socio1 = new socios();
            socio2 = new socios(); 
            socio3 = new socios();
                }
        public void responsabilidad()
        {
            string nombreViejo = socio1.devolverNom();
            int antiguedad = socio1.devolverAnt();
            if (antiguedad < socio2.devolverAnt())
            {
                nombreViejo = socio2.devolverNom();
                antiguedad = socio2.devolverAnt();
            }
            if (antiguedad<socio3.devolverAnt())
            {
                nombreViejo= socio3.devolverNom();
                antiguedad= socio3.devolverAnt();
            }
            Console.WriteLine("El socio mas viejo es:"+nombreViejo+ " Con"+antiguedad+" años");
        }
        static void Main(string[] args)
        {
            Club club = new Club();
            club.responsabilidad();
            Console.ReadKey();
        }
    }
}
