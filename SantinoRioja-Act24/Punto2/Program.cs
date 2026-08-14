using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{ /*8-
Una farmacia controla el nivel de stock de sus medicamentos para evitar el
desabastecimiento de insumos esenciales.
 Crear la clase Medicamento que contenga los atributos privados: nombre
(string) y stock (int). Definir sus propiedades correspondientes. Su
constructor debe recibir nom y stk.
 Crear la clase ControlFarmacia que administre una lista de objetos List.
 Métodos en ControlFarmacia:
o Un constructor que cargue por teclado una lista inicial de 4
medicamentos ingresando sus nombres y stock.
o ListarStock(): Mostrar la lista de medicamentos en pantalla.

o RemoverAgotados(): Recorrer la lista y remover por completo de
la colección a todos aquellos medicamentos cuyo stock sea igual a 0.
o MostrarMedicamentosDisponibles(): Imprimir la lista
actualizada y la cantidad de productos disponibles en el inventario
utilizando la propiedad .Count.*/
    class Medicamento
    {
        private string nombre;
        private int stock;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }
        public Medicamento(string nom, int stk)
        {
            nombre = nom;
            stock = stk;
        }
    }
    class ControlFarmacia
    {
        List<Medicamento> medicamentos = new List<Medicamento>();
        public ControlFarmacia()
        {
            string nom;
            int stk = 0;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Ingrese nombre de medicamento");
                nom = Console.ReadLine();
                Console.WriteLine("Ingrese su Stock");
                stk = int.Parse(Console.ReadLine());
                medicamentos.Add(new Medicamento(nom, stk));
            }
        }
        public void ListarStock()
        {
            Console.WriteLine("Listado de medicamentos:");
            foreach (Medicamento medicamento in medicamentos)
            {
                Console.WriteLine("Nombre:" + medicamento.Nombre + "   Stock:" + medicamento.Stock);
            }
        }
        public void RemoverAgotados()
        {
            medicamentos.RemoveAll(medicamento => medicamento.Stock == 0);
            Console.WriteLine("Se eliminaron todos los medicamentos con Stock 0");
        }
        public void MostrarMedicamentosDisponibles()
        {
            Console.WriteLine("Lista actualizada:");
            foreach (Medicamento medicamento in medicamentos)
            {
                Console.WriteLine("Nombre:" + medicamento.Nombre + "   Stock:" + medicamento.Stock);
            }
            Console.WriteLine("Cantidad de productos disponibles en el inventario:" + medicamentos.Count);
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            ControlFarmacia control1 = new ControlFarmacia();
            control1.ListarStock();
            control1.RemoverAgotados();
            control1.MostrarMedicamentosDisponibles();
            Console.ReadKey();
        }
    }
}

