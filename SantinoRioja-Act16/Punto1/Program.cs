using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{/*1. Confeccionar una clase Persona que tenga como atributos el nombre y la
edad (definir las propiedades para poder acceder a dichos atributos). Definir
un método para imprimirlos. Plantear una segunda clase Empleado que
herede de la clase Persona. Añadir un atributo sueldo ( y su propiedad) y el
método para imprimir su sueldo. Definir un objeto de la clase Persona y
llamar a sus métodos y propiedades. También crear un objeto de la clase
Empleado y llamar a sus métodos y propiedades.*/
    class Persona
    {
        protected string nombre;
        protected int edad;
        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public int Edad
        {
            set { edad = value; }
            get { return edad; }
        }
        public void imprimir() { Console.WriteLine("Nombre de la persona:" + nombre + " Edad:" + edad); }

    }
    class Empleado : Persona
    {
        protected float sueldo;
        public float Sueldo
        {
            set { sueldo = value; }
            get { return sueldo; }
            
        }
        public void ImpSueldo() { Console.WriteLine("Sueldo del empleado:"+ sueldo); }
    }
    internal class Programa
    {
        static void Main(string[] args)
        { Persona persona5 = new Persona();
            persona5.Nombre = "Santi";
            persona5.Edad = 67;
            persona5.imprimir();
            Empleado empleado3 = new Empleado();
            empleado3.Nombre = "Enrique";
            empleado3.Edad = 89;
            empleado3.Sueldo = 3;
            empleado3.imprimir();
            empleado3.ImpSueldo();
            Console.ReadKey();
        }
    }
}
