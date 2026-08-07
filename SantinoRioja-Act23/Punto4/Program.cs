using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    /*4-

Un sistema central de domótica gestiona el consumo de los artefactos inteligentes
vinculados a una red hogareña.
 Crear la clase DispositivoInteligente que contenga como atributos
privados: nombreDispositivo (string) y consumoWatts (double). Definir
sus propiedades y un constructor que reciba nom y watts.

 Crear la clase colaboradora PanelDomotico que administre un objeto
List<DispositivoInteligente>.
 Métodos en PanelDomotico:
1. Un constructor que permita al usuario cargar dinámicamente
dispositivos por teclado. El sistema preguntará después de cada
carga si se desea agregar otro dispositivo.
2. MostrarDispositivos(): Listar todos los dispositivos
configurados junto a sus consumos.
3. CalcularConsumoTotal(): Calcular y mostrar en pantalla los
Watts totales que consume la casa sumando los valores de la lista.
4. DesconectarDispositivo(): Solicitar al usuario el nombre de
un dispositivo y, si existe en la lista, removerlo de forma dinámica
para simular su apagado remoto.*/
    class DispositivoInteligente
    {
        private string nombreDispositivo;
        private double consumoWatts;

        public string NombreDispositivo
        {
            get { return nombreDispositivo; }
            set { nombreDispositivo = value; }
        }
        public double ConsumoWatts
        {
            get { return consumoWatts; }
            set { consumoWatts = value; }
        }
        public DispositivoInteligente(string nom, double watts) { 
            nombreDispositivo = nom;
            consumoWatts = watts;
        }

    }
    class PanelDomotico
    {
        List<DispositivoInteligente> dispositivosInteligentes = new List<DispositivoInteligente>();
        public PanelDomotico() { 
        bool programa = true;
            while (programa == true) {
                string nom;
                double watts;
                Console.WriteLine("Ingrese el nombre del dispositivo a vincular");
                nom = Console.ReadLine();
                Console.WriteLine("Ingrese los watts que consume el dispositivo");
                watts = double.Parse(Console.ReadLine());
                dispositivosInteligentes.Add(new DispositivoInteligente(nom,watts));
                Console.WriteLine("Desea ingresar otro dispositivo? S o N");
                string linea = Console.ReadLine();
                bool bucle = true;
                while (bucle == true)
                {
                    if (linea != "S" && linea != "N")
                    {
                        Console.WriteLine("Ingrese una letra valida");
                        linea = Console.ReadLine();
                    }
                    else { bucle = false; }
                }
                if (linea == "N")
                {
                    programa= false;
                }
            }
        }
        public void MostrarDispositivos()
        {
            Console.WriteLine("Listado de dispotivos configurados:");
            foreach (DispositivoInteligente dispositivo in dispositivosInteligentes)
            {
                Console.WriteLine("Nombre:"+dispositivo.NombreDispositivo+ "      Consumo en watts:"+ dispositivo.ConsumoWatts);
            }
        }
        public void CalcularConsumoTotal()
        {
            double consumoTotal = 0;
            foreach (DispositivoInteligente dispositivo in dispositivosInteligentes)
            {
                consumoTotal += dispositivo.ConsumoWatts;
            }
            Console.WriteLine("Consumo total de los dispositivos en la casa:"+consumoTotal);
        }
        public void DesconectarDispositivo()
        {
            Console.WriteLine("Ingrese el dispositivo para desconectar");
            string dispositivoDesconectar = Console.ReadLine();
            bool existe = false;
            for (int i = dispositivosInteligentes.Count - 1; i >= 0; i--)
            {
                if (dispositivosInteligentes[i].NombreDispositivo == dispositivoDesconectar)
                {
                    dispositivosInteligentes.RemoveAt(i);
                    Console.WriteLine("Se elimino correctamente");
                    existe = true;
                }
            } 
            if (existe == false)
            {
                Console.WriteLine("Ese dispositivo no existe en la lista");
            }
        }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            PanelDomotico panelDomotico1 = new PanelDomotico();
            panelDomotico1.MostrarDispositivos();
            panelDomotico1.CalcularConsumoTotal();
            panelDomotico1.DesconectarDispositivo();
            panelDomotico1.MostrarDispositivos();
            Console.ReadKey();
        }
    }
}
