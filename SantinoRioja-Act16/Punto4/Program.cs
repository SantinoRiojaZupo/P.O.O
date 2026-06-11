using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    /*4. Armar tres clases: Animal, Mamífero y Perro.
La clase Animal debe tener un atributo especie.
La clase Mamífero, que hereda de Animal, debe tener un atributo
tipoAlimentacion.
La clase Perro, que hereda de Mamífero, debe tener un atributo nombre.
Cada clase debe tener un constructor que reciba los datos correspondientes
y los imprima indicando a qué clase pertenecen. Los datos deben ser
asignados previamente
Crear un objeto de la clase Perro y verificar la ejecución en cadena de los
constructores.*/
    class Animal
    {
        protected string especie;

        public string Especie
        {
            set { especie = value; }
            get { return especie; }
        }
        public Animal()
        {
            especie = "mamifero";
            Console.WriteLine("Clase:Animal dato:"+especie);
        }
    }
    class Mamifero : Animal {
       protected string tipoAlimentacion;

        public string TipoAlimentacion
        {
            set { tipoAlimentacion = value; }
            get { return tipoAlimentacion; }
        }
        public Mamifero() {
            tipoAlimentacion = "Herbivoro";
            Console.WriteLine("Clase:Mamifero dato:"+ tipoAlimentacion);
        }
    }
    internal class Perro : Mamifero
    {
        protected string nombre;
        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public Perro() {
            nombre = "Ringo";
            Console.WriteLine("Clase:Perro dato:"+ nombre);
        }
        static void Main(string[] args)
        {
            Perro perro1 = new Perro();
            perro1.nombre = "Ringo";
            perro1.especie = "Mamifero";
            perro1.tipoAlimentacion = "Herbivoro";
            Console.WriteLine("Especie:" + perro1.especie + " Tipo de alimentacion:" + perro1.tipoAlimentacion + " Nombre:" + perro1.nombre);
            
            Console.ReadKey();
        }
    }
}
