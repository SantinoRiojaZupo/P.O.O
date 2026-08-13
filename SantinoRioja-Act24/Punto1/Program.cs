using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    /*7-
Un restaurante automatizado procesa la comanda de una mesa para controlar la
preparación y el cobro de los platos pedidos.

 Crear la clase Plato que contenga como atributos privados: nombrePlato
(string) y precio (double). Definir sus propiedades correspondientes y un
constructor que reciba nom y pre.

 Crear la clase GestionComandas que administre una lista de objetos List.

 Métodos en GestionComandas:

o AgregarPlato():Solicitar por teclado los datos de un plato y
agregarlo a la lista utilizando .Add().

o MostrarComanda(): Listar todos los platos agregados hasta el
momento junto a la cantidad total de ítems pedidos utilizando la
propiedad .Count.

o CalcularTotalMesa(): Calcular y mostrar en pantalla el monto
total a cobrar sumando los precios de la lista.

o CancelarPlato(): Solicitar al usuario el nombre de un plato y, si
se encuentra en la lista, removerlo mediante .Remove() para
actualizar la comanda.*/
    class Plato
    {
        private string nombrePlato;
        private double precio;

        public string NombrePlato
        {
            get { return nombrePlato; }
            set { nombrePlato = value; }
        }
        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public Plato(string nom, double pre)
        {
            nombrePlato= nom;
            precio = pre;
        }
    }
    class GestionComandas
    {
        List<Plato> platos= new List<Plato>();

        public void AgregarPlato()
        {
            string nom;
            double pre;
            Console.WriteLine("Ingrse el nombre del plato");
            nom = Console.ReadLine();
            Console.WriteLine("Ingrese el precio del plato");
            pre = double.Parse(Console.ReadLine());
            platos.Add(new Plato(nom, pre));
        }
        public void MostrarComanda()
        {
            foreach (Plato plato in platos) {
                Console.WriteLine("Plato:"+plato.NombrePlato+"  Precio:"+plato.Precio);
                    }
            Console.WriteLine("Cantidad de items pedidos" + platos.Count);

        }
        public void CalcularTotalMesa()
        {
            double total = 0;
            foreach (Plato plato in platos)
            {
                total += plato.Precio;
            }
            Console.WriteLine("Total monto total a cobrar en la mesa:" + total);
        }
        public void CancelarPlato()
        {
            string platoBorrar;
            Console.WriteLine("Ingrese el nombre del plato que quiere borrar ");
            platoBorrar= Console.ReadLine();
            platos.RemoveAll(plato=>plato.NombrePlato==platoBorrar);
            Console.WriteLine("Se borro el plato si existia en el pedido");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            GestionComandas gestionComandas1 = new GestionComandas();
            gestionComandas1.AgregarPlato();
            gestionComandas1.AgregarPlato();
            gestionComandas1.AgregarPlato();
            gestionComandas1.MostrarComanda();
            gestionComandas1.CalcularTotalMesa();
            gestionComandas1.CancelarPlato();
            gestionComandas1.MostrarComanda();
            Console.ReadKey();
        }
    }
}
