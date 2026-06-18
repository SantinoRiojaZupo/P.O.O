using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{/*3.
Crear una clase base llamada SondaExploradora que contenga los atributos Modelo (string) y
AutonomiaMinutos (int). Definir un constructor que reciba estos dos valores como parámetros y
realice su asignación.
Luego, definir dos clases derivadas de la clase base:
● SondaSubmarina: que añade el atributo propio PresionMaximaAtm (int, presión máxima
soportada en atmósferas).
● RoverTerrestre: que añade el atributo propio CantidadRuedas (int).
Cada una de estas clases derivadas debe poseer su propio constructor. El mismo debe recibir
tanto el atributo específico como los heredados de la clase base, transfiriendo estos últimos a la
clase SondaExploradora mediante el uso explícito de la palabra clave base.
En el método Main, instanciar un objeto de cada clase derivada y mostrar la totalidad de sus
parámetros unificados por consola.*/
    class SondaExploradora
    {
        protected string modelo;
        protected int autonomiaMinutos;
        public SondaExploradora(string mod, int autMin)
        {
            modelo = mod;
            autonomiaMinutos = autMin;
        }
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public int AutonomiaMinutos
        {
            get
            {
                return autonomiaMinutos;
            }
            set { autonomiaMinutos = value; }
        }
    }
    class SondaSubmarina : SondaExploradora
    {
        protected int presionMaximaAtm;
        public SondaSubmarina(string mod, int autMin, int presMax) : base (mod, autMin)
        {
            presionMaximaAtm = presMax;
        }
        public int PresionMaximaAtm
        {
            get { return presionMaximaAtm; }
            set { presionMaximaAtm = value; }
        }
    }
    class RoverTerrestre : SondaExploradora 
    {
        protected int cantidadRuedas;
        public RoverTerrestre(string mod, int autMin, int ruedas) : base (mod, autMin) 
        {
            cantidadRuedas = ruedas;
        }
        public int CantidadRuedas
        {
            get { return cantidadRuedas; }
            set { cantidadRuedas = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SondaSubmarina sondaSubmarina1 = new SondaSubmarina("tesla",67,89);
            RoverTerrestre roverTerrestre1 = new RoverTerrestre("Subaru",20,37);
            Console.WriteLine("Modelo:"+sondaSubmarina1.Modelo+" Autonomia por minutos:"+sondaSubmarina1.AutonomiaMinutos+" Presion maxima:"+sondaSubmarina1.PresionMaximaAtm);
            Console.WriteLine("Modelo:" + roverTerrestre1.Modelo + " Autonomia por minutos:" + roverTerrestre1.AutonomiaMinutos + " Cantidad de ruedas:" + roverTerrestre1.CantidadRuedas);
            Console.ReadKey();
        }
    }
}
