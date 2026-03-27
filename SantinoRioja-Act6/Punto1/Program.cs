using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Plano
    {
        //1. Desarrollar una clase que represente un punto en el plano y tenga los siguientes métodos
        //:cargar los valores de x e y, imprimir en que cuadrante se encuentra dicho punto
        //(concepto matemático, primer cuadrante si x e y son positivas, si x&lt;0 e y&gt;0 segundo cuadrante, etc.)
        private int x,y;

        public void inicializar() {
            Console.WriteLine("Ingrese valores de x");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese valores de y");
            y = int.Parse(Console.ReadLine());
        }

        public void calcularCuadrante() {
            if (x > 0 && y > 0)
            {
                Console.WriteLine("Esta en el primer cuadrante");
            }
            else if (x < 0 && y > 0) { Console.WriteLine("Esta en el segundo cuadrante"); }
            else if (x > 0 && y < 0) { Console.WriteLine("Esta en el tercer cuadrante"); }
            else if (x<0 && y<0) { Console.WriteLine("Esta en el cuarto cuadrante"); }
        }

        static void Main(string[] args)
        {
            Plano plano1 = new Plano();
            plano1.inicializar();
            plano1.calcularCuadrante();
            Console.ReadKey();
        }
    }
}
