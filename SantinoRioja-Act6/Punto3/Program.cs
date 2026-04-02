using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Empleado
        //3. Confeccionar una clase que represente un empleado.
        //Definir como atributos su nombre y su sueldo.
        //Confeccionar los métodos para la carga,
        //otro para imprimir sus datos
        //y por último uno que imprima un mensaje si debe pagar impuestos(si el sueldo supera a 3000).
    {
        private string nombre;
        private int sueldo;

        public void Cargar()
        {
            Console.WriteLine("Ingrese el nombre del empleado:");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el sueldo del empleado:");
            sueldo = int.Parse(Console.ReadLine());
        }

        public void Imprimir()
        {
            Console.WriteLine("Nombre del empleado: " + nombre);
            Console.WriteLine("Sueldo del empleado: " + sueldo);
            if (sueldo > 3000) {
                Console.WriteLine("El empleado debe pagar impuestos");
            }
        }
        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado();
            empleado1.Cargar();
            empleado1.Imprimir();
            Console.ReadKey();
        }
    }
}
