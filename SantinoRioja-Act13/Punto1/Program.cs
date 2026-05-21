using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
   /* 1. Confeccionar una clase que represente un empleado.
    * Definir como atributos su nombre y su sueldo.
    * En el constructor cargar los atributos
    * y luego en otro método imprimir sus datos 
    * y por último uno que imprima un mensaje si debe pagar impuestos(si el sueldo supera a 3000)*/

    internal class Empleado
    {
        private string nombre;
        private float sueldo;

        public Empleado()
        {
            Console.WriteLine("Ingrese el nombre del empleado");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su sueldo");
            sueldo = int.Parse(Console.ReadLine());
        }
        public void imprimir()
        {
            Console.WriteLine("Nombre:"+nombre+" Sueldo:"+sueldo);
        }
        public void impuestos()
        {
            if (sueldo > 3000) { Console.WriteLine("Debe pagar impuestos"); }
        }
        static void Main(string[] args)
        { Empleado empleado1 = new Empleado();
            empleado1.imprimir();
            empleado1.impuestos();
            Console.ReadKey();
        }
    }
}
