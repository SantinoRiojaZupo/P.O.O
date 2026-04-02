using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class operaciones
    //4. Implementar la clase operaciones.
    //Se deben cargar dos valores enteros,
    //calcular su suma, resta, multiplicación y división, cada una en un método,
    //imprimir dichos resultados.
    {
        private float  num1, num2;
        public void cargar()
        {
            Console.WriteLine("Ingrese el primer numero: ");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            num2 = float.Parse(Console.ReadLine());
        }
        
        public void suma() {
            Console.WriteLine("La suma es: " + (num1 + num2));
        }
        public void resta()
        {
            Console.WriteLine("La resta es: " + (num1 - num2));
        }
        public void multiplicacion()
        {
            Console.WriteLine("La multiplicacion es: " + (num1 * num2));
        }
        public void division() { 
        
            Console.WriteLine("La division es: " + (num1 / num2));
        }

        public
        static void Main(string[] args)
        {
            operaciones operacion1 = new operaciones();
            operacion1.cargar();
            operacion1 .suma();
            operacion1.resta();
            operacion1.multiplicacion();
            operacion1.division();
            Console.ReadKey();
        }
    }
}
