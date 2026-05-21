using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class operaciones
    {
        /*2. Implementar la clase operaciones. 
        Se deben cargar dos valores enteros en el constructor, 
        calcular su suma, resta, multiplicación y división, cada una en un método, imprimir dichos resultados.*/
        private int num1, num2;
        public  operaciones() {
            Console.WriteLine("Ingrese numero 1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numero 2");
            num2 = int.Parse(Console.ReadLine());
        }
        public void suma() {
            Console.WriteLine("suma:" + (num1 + num2));
        }
        
        public void resta()
        {
            Console.WriteLine("Resta:"+ (num1-num2));
        }

        public void multiplicacion()
        {
            Console.WriteLine("Multiplicacion:"+(num1*num2));
        }
        public void division()
        {
            Console.WriteLine("Division:"+ ((float)num1/(float)num2));
        }
        static void Main(string[] args)
        {
            operaciones operaciones1 = new operaciones();
            operaciones1.suma();
            operaciones1 .resta();
            operaciones1.multiplicacion();
            operaciones1.division();
            Console.ReadKey();
        }
    }
}
