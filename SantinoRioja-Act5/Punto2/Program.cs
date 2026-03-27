using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. Realizar un programa que lea los lados de n triángulos, e informar:
            //a) De cada uno de ellos, qué tipo de triángulo es: equilátero(tres lados iguales), isósceles(dos lados iguales), o escaleno(ningún lado igual)
            //b) Cantidad de triángulos de cada tipo.
            //c) Tipo de triángulo que posee menor cantidad.
            int cantTriagulos, lado1, lado2, lado3;
            int equilateros = 0, isosceles = 0, escaleno = 0;
            Console.WriteLine("Ingrese la cantidad de tringualos que desee comparar");
            cantTriagulos = int.Parse(Console.ReadLine());
            for (int i = 1; i <= cantTriagulos; i++)
            {
                Console.WriteLine("Ingrese el primer lado");
                lado1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo lado");
                lado2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el tercer lado");
                lado3 = int.Parse(Console.ReadLine());
                if (lado1 == lado2 && lado1 == lado3)
                {
                    Console.WriteLine("Su triangulo es equilatero");
                    equilateros++;
                }
                else
                if (lado1 == lado2 || lado2 == lado3 || lado3 == lado1)
                {

                    Console.WriteLine("Su triangulo es isosceles");
                    isosceles++;
                }
                else { Console.WriteLine("Su triangulo es escaleno");
                    escaleno++;
                }

            }
            Console.WriteLine("La cantidad de triangulos equilateros es: " + equilateros);
            Console.WriteLine("La cantidad de triangulos isosceles es: " + isosceles);
            Console.WriteLine("La cantidad de triangulos escalenos es: " + escaleno);
            if (escaleno < equilateros && escaleno < isosceles) { Console.WriteLine("El triangulo con menor cantidad es el escaleno"); }
            else if (equilateros < escaleno && equilateros < isosceles) { Console.WriteLine("el triangulo con menor cantidad  es el equilatero"); }
            else  if (isosceles < escaleno && isosceles < equilateros) { Console.WriteLine("El triangulo con menor cantidad es el isosceles"); }
            else { Console.WriteLine("hay 2 o mas que son igual de pequeños"); }
            Console.ReadKey();
        }

        }
    }

