using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    /*Actividad 2: Administración de entregas logísticas
Problema:
Una empresa de envíos desea registrar sus entregas mediante colaboración de
clases.
Crear una clase Paquete con propiedades: código, peso y destino.
Crear una clase Despachador que contenga una lista de paquetes y un método para registrar nuevos
paquetes.
Desde el método Main, instanciar un Despachador, cargar 5 paquetes y mostrar:
 Todos los paquetes registrados.
 Cuántos superan los 10 kg de peso.
 Cuántos tienen destino nacional (por ejemplo, “Argentina”).*/
    class Paquete
    {
        protected int codigo;
        protected float peso;
        protected string destino;
        public Paquete()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Ingrese el codigo del paquete");
            codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el peso del paquete");
            peso = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el destino del paquete");
            destino = Console.ReadLine();
            Console.WriteLine("-------------------------------");
        }
        public int Codigo
        {
            get { return codigo; }
            set{ codigo = value; }
        }
        public float Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        public string Destino
        {
            get { return destino; }
            set { destino= value; }
        }
    }
    class despachador
    {
        public List<Paquete> paquetes { set; get; } = new List<Paquete>();
        public void registrarPaquete()
        {
            Paquete nuevoPaquete = new Paquete();
            paquetes.Add(nuevoPaquete);
        }
      
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int superan10KG = 0;
                int paqueteNacional = 0;
            despachador despachador1 = new despachador();
            despachador1.registrarPaquete();
            despachador1.registrarPaquete();
            despachador1.registrarPaquete();
            despachador1.registrarPaquete();
            despachador1.registrarPaquete();
            foreach(Paquete m in despachador1.paquetes){
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Codigo del paquete:"+ m.Codigo);
                Console.WriteLine("Peso del paquete:" + m.Peso);
                Console.WriteLine("Destino del paquete:" + m.Destino);
                if (m.Peso > 10)
                {
                    Console.WriteLine("El paquete supera los 10 kilos");
                    superan10KG++;
                }
                if (m.Destino == "Argentina")
                {
                    Console.WriteLine("El paquete es envio nacional");
                    paqueteNacional++;
                } 
                Console.WriteLine("-------------------------------");

            }
                Console.WriteLine("Los paquetes que superan los 10 kilos:"+ superan10KG);
                Console.WriteLine("Los paquetes que son envio nacional:" + paqueteNacional);
            Console.ReadKey();
        }
    }
}
