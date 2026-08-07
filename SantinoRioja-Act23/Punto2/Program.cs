using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{ /*2-
Una empresa de logística autónoma monitorea el estado y nivel de batería de sus
drones de entrega en vuelo de regreso a la base.
 Crear la clase Dron que contenga los atributos privados: codigo (string) y
nivelBateria (int, de 0 a 100). Definir sus propiedades correspondientes.
Su constructor debe recibir cod y bat.
 Crear la clase CentroControl que administre una lista de objetos
List&lt;Dron&gt;.
 Métodos en CentroControl:

1. Un constructor que cargue por teclado una lista inicial de 4 drones
ingresando sus códigos y baterías.
2. ListarFlota(): Mostrar la lista de drones en pantalla.
3. RemoverDronesBajos(): Recorrer la lista y remover por
completo de la flota a todos aquellos drones cuyo nivel de batería
sea menor o igual al 15% (ya que requieren mantenimiento
automático urgente).
4. MostrarDronesRestantes(): Imprimir la flota actualizada y la
cantidad de drones operativos utilizando la propiedad .Count.*/
    class Dron {
        private string codigo;
        private int nivelBateria;

        public Dron(string cod, int bat)
        {
            codigo = cod;
            nivelBateria = bat;
        }
        public string Codigo
        {
            get {  return codigo; }
            set { codigo = value; }
            
        }
        public int NivelBateria
        {
            get { return nivelBateria; }
            set { nivelBateria = value; }
        }

    }
    class CentroControl
    {
        List<Dron> drones = new List<Dron>();
        public CentroControl()
        {
            for (int i = 0; i < 4; i++)
            {
                string cod;
                int bat;
                Console.WriteLine("Ingrese codigo del dron");
                cod = Console.ReadLine();
                Console.WriteLine("Ingrese la bateria del dron, recuerde que no puede ser menor a 0 ni mayor a 100");
                bat = int.Parse(Console.ReadLine());
                if (bat < 0 || bat > 100)
                {
                    Console.WriteLine("Recuerde que el nivel de bateria debe ser mayor a 0 y menor a 100, reiniciando creacion del dron");
                    i--;
                }
                else
                {
                    drones.Add(new Dron(cod,bat));
                }
            }
        }
        public void ListarFlota()
        {
            Console.WriteLine("Listado de drones:");
            foreach (Dron drons in drones)
            {
                Console.WriteLine("Codigo:"+drons.Codigo+"      Bateria:"+drons.NivelBateria );
            }
        }
        public void RemoverDronesBajos()
        {
            for (int i = drones.Count-1;i >= 0; i--)
            {
                if (drones[i].NivelBateria <= 15)
                {
                    drones.RemoveAt(i);
                }
            }
        }
        public void MostrarDronesOperativos()
        {
            Console.WriteLine("Listado de drones restantes:");
            foreach (Dron drons in drones)
            {
                Console.WriteLine("Codigo:" + drons.Codigo + "      Bateria:" + drons.NivelBateria);
            }
            Console.WriteLine("Cantidad de drones operativos:"+drones.Count);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CentroControl centroControl1 = new CentroControl();
            centroControl1.ListarFlota();
            centroControl1.RemoverDronesBajos();
            centroControl1.MostrarDronesOperativos();
            Console.ReadKey();
        }
    }
}
