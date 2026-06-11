using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{/*3. Crear una clase base Vehículo que contenga atributos marca y
velocidadMaxima.
Definir dos clases derivadas: Auto y Moto, que hereden de Vehículo. Cada
una debe tener un constructor que reciba los valores de los atributos base
mediante la palabra clave base, y un atributo propio (cantidadPuertas en
Auto, cilindrada en Moto).
Crear un objeto de cada clase y mostrar todos sus datos por consola.*/
    class Vehiculo
    {
        protected string marca;
        protected float velocidadMaxima;
        string base1;
        float base2;
        public Vehiculo()
        {
            Console.WriteLine("Ingrese marca");
            base1 = Console.ReadLine();
            Console.WriteLine("Ingrse velocidad Maxima");
            base2 = float.Parse(Console.ReadLine());
            marca = base1;
            velocidadMaxima = base2;
            Console.WriteLine("Marca:"+ marca+ " Velocidad Maxima: "+ velocidadMaxima);
        }
    }
    class Auto : Vehiculo {
        int cantidadPuertas;

        public Auto()
        {
            string base1 = marca;
            float base2 = velocidadMaxima;
            Console.WriteLine("Ingrese la cantidad de puertas del auto");
            cantidadPuertas = int.Parse(Console.ReadLine());
            Console.WriteLine("Marca:"+base1+ " Velocidad Maxima:" + base2+ " Puertas:"+ cantidadPuertas);
        }
    }
    class Moto : Vehiculo {
        int cilindrada;
        public Moto()
        {
            string base1 = marca;
            float base2 = velocidadMaxima;
            Console.WriteLine("Ingrese la cantidad de cilindrada");
            cilindrada = int.Parse(Console.ReadLine());
            Console.WriteLine("Marca:" + base1 + " Velocidad Maxima:" + base2 + " Cilindrada:" + cilindrada);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {Auto auto1 = new Auto();
            Moto moto1 = new Moto();

            Console.ReadKey();
        }
    }
}
