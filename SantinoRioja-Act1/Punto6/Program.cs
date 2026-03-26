using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //6. Escribir un programa que lea el peso (en kilogramos) y la altura (en metros) de una persona
            //, y mostrar por pantalla su índice de masa corporal (IMC) (El IMC se calcula dividiendo el peso entre el cuadrado de la altura).
            float peso, altura, imc;

            Console.WriteLine("Indique peso en Kilogramos(KG):");
            peso = float.Parse(Console.ReadLine());

            Console.WriteLine("Indique altura en Metros(M):");
            altura = float.Parse(Console.ReadLine());

            imc = peso / (altura * altura);

            Console.WriteLine("El indice de masa corporal(IMC) es de:"+ imc);
            Console.ReadKey();
        }
    }
}
