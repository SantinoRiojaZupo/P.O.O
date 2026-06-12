using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{/*3. Fábrica de Computadoras (Herencia y Constructores con base)
Crear una clase base llamada Computadora que contenga los atributos Marca y
MemoriaRAM (en GB). Definir un constructor que reciba estos dos valores obligatoriamente.
Luego, definir dos clases derivadas de la clase base:
 Notebook: que añade el atributo propio TamanoPantalla (en pulgadas).
 Escritorio: que añade el atributo propio PotenciaFuente (en Watts).
Cada una de estas clases derivadas debe poseer su propio constructor, el cual debe recibir
tanto los atributos específicos como los de la clase base, transfiriendo estos últimos a la
clase Computadora mediante el uso explícito de la palabra clave base. Instanciar un objeto
de cada clase derivada en el Main y mostrar la totalidad de sus datos por consola.*/
    class Computadora
    {
        protected string baseMarca;
        protected int baseMemoriaRAM;

        public string BaseMarca
        {
            get { return baseMarca; }
            set { baseMarca = value; }
        }
        public int BasememoriaRAM
        {
            get { return baseMemoriaRAM; }
            set { baseMemoriaRAM = value; }
        }
        public Computadora()
        {
            Console.WriteLine("Ingrese marca");
            baseMarca = Console.ReadLine();
            Console.WriteLine("Ingrese la Memoria Ram en GB");
            baseMemoriaRAM = int.Parse(Console.ReadLine());
        }
    }
    class Notebook : Computadora {
        private float tamañoPantalla;

        public float TamañoPantalla
        {
            get { return tamañoPantalla; }
            set { tamañoPantalla = value; }
        }
        public Notebook() {     
            Console.WriteLine("Ingrese el tamaño de la pantalla en pulgadas");
            tamañoPantalla = float.Parse(Console.ReadLine());
        }
    }
    class Escritorio : Computadora 
    {
        private int potenciaFuente;
        public int PotenciaFuente
        {
            get { return potenciaFuente; }
            set { potenciaFuente = value; }
        }
        public Escritorio()
        {
            Console.WriteLine("Ingrese la potencia de la fuente en Watts");
            potenciaFuente = int.Parse(Console.ReadLine());
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook1 = new Notebook();
            Escritorio escritorio1 = new Escritorio();
            Console.WriteLine("Marca:"+ notebook1.BaseMarca+ " Cantidad de GB RAM:"+notebook1.BasememoriaRAM+ " Tamaño de pantalla en pulgadas:"+ notebook1.TamañoPantalla);
            Console.WriteLine("Marca:" + escritorio1.BaseMarca + " Cantidad de GB RAM:" + escritorio1.BasememoriaRAM + " Potencia de la fuente en Watts:" + escritorio1.PotenciaFuente);
            Console.ReadKey();
        }
    }
}
