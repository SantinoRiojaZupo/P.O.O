using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Program
    {
        /*Actividad 2: Posicionamiento de elementos en consola
Problema:
Definir una clase ElementoPantalla con atributos: nombre, posX y posY.
 Implementar propiedades y un constructor que cargue valores.
 Crear un método Mostrar() que use Console.SetCursorPosition() para ubicar el
nombre en pantalla y Console.CursorVisible para ocultar el cursor.
 Generar un vector de 4 elementos y mostrarlos en distintas posiciones en la
consola.*/
        class ElementoPantalla
        {
            string nombre;
            int posX, posY;
            public ElementoPantalla()
            {
                Console.WriteLine("Ingrese el nombre del elemento");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la posición X del elemento");
                posX = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la posición Y del elemento");
                posY = int.Parse(Console.ReadLine());
            }
            public string Nombre
            {
                set { nombre = value; }
                get { return nombre; }
            }
            public int PosX
            {
                set;
                get;
            }
            public int PosY
            {
                set;
                get;
            }
            public void Mostrar()
            {
                Console.SetCursorPosition(posX, posY);
                Console.CursorVisible = false;
                Console.WriteLine(nombre);
            }
        }
        static void Main(string[] args)
        {
            ElementoPantalla[] elementos = new ElementoPantalla[4];
            elementos[0] = new ElementoPantalla();
            elementos[1] = new ElementoPantalla();
            elementos[2] = new ElementoPantalla();
            elementos[3] = new ElementoPantalla();
            Console.Clear();
            foreach (var m in elementos)
            {
                m.Mostrar();
            }

            Console.ReadKey();
        }
    }
}
