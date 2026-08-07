using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto5
{
    /*5-
Un taller mecánico automatizado administra la recepción y egreso de automóviles
que se encuentran en el sector de reparaciones.
 Crear la clase Vehiculo que contenga como atributos privados: patente
(string) y costoReparacion (double). Definir sus propiedades
correspondientes y un constructor que reciba pat y costo.

 Crear la clase GestionTaller que administre una lista de objetos List.
 Métodos en GestionTaller:
o IngresarVehiculo(): Solicitar por teclado la patente y el costo de
reparación de un vehículo para agregarlo a la lista mediante .Add().
o BuscarVehiculo(): Pedir al operador que ingrese una patente y,
recorriendo la lista, informar si el vehículo está en el taller y mostrar
su costo asociado.
o EntregarVehiculo(): Solicitar una patente por teclado, buscar el
vehículo en la lista y, si existe, removerlo de la colección mediante
.Remove() confirmando la entrega del automóvil.

o CalcularRecaudacionPendiente(): Listar los vehículos
actualmente en reparación, la cantidad total de unidades alojadas en
el taller mediante la propiedad .Count y la suma total acumulada por
cobrar.*/
    class Vehiculo
    {
        private string patente;
        private double costoReparacion;
        public string Patente
        {
            get { return patente; }
            set { patente = value; }
        }
        public double CostoReparacion
        {
            get { return costoReparacion; }
            set { costoReparacion = value; }
        }
        public Vehiculo(string pat, double costo)
        {
            patente = pat;
            costoReparacion = costo;
        }
    }
    class GestionTaller
    {
        List<Vehiculo>vehiculos = new List<Vehiculo>();

        public void IngresarVehiculo()
        {
            string pat;
            double costo;
            Console.WriteLine("Ingrese la patente del vehiculo a ingresar");
            pat = Console.ReadLine();
            Console.WriteLine("Ingrese el costo de reparacion del vehiculo a ingresar");
            costo = double.Parse(Console.ReadLine());
            vehiculos.Add(new Vehiculo(pat,costo));

        }
        public void BuscarVehiculo()
        {
            string patenteBuscar;
            double costo = 0;
            Console.WriteLine("Ingrese una patente para buscar");
            patenteBuscar = Console.ReadLine();
            foreach (Vehiculo vehiculo in vehiculos)
            {
                if (vehiculo.Patente== patenteBuscar)
                {
                    costo = vehiculo.CostoReparacion;
                }
            }
            if (costo > 0)
            {
                Console.WriteLine("El vehiculo esta en el taller y su costo de reparacion es de:"+ costo);
            }
            else
            {
                Console.WriteLine("La patente ingresada no esta en el taller");
            }
        }
        public void EntregarVehiculo()
        {
            string patenteBuscar;
            Console.WriteLine("Ingrese una patente para entregar");
            patenteBuscar = Console.ReadLine();
            vehiculos.RemoveAll(vehiculo=>vehiculo.Patente==patenteBuscar);
            Console.WriteLine("Se entrego el vehiculo con esa patente si es que estaba en el taller");
        }
        public void calcularRecaudacionPendiente()
        {
            double recaudacionTotal = 0;
            Console.WriteLine("Listado de vehiculos que quedan por reparar:");
            foreach (Vehiculo vehiculo in vehiculos)
            {
                Console.WriteLine("Patente:"+vehiculo.Patente+ "    costo de reparacion:"+vehiculo.CostoReparacion);
                recaudacionTotal += vehiculo.CostoReparacion;
            }
            Console.WriteLine("Cantidad total de vehiculos en el taller:"+ vehiculos.Count);
            Console.WriteLine("Cantidad sumada por cobrar:"+ recaudacionTotal);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            GestionTaller gestionTaller1 = new GestionTaller();
            gestionTaller1.IngresarVehiculo();
            gestionTaller1.IngresarVehiculo();
            gestionTaller1.IngresarVehiculo();
            gestionTaller1.BuscarVehiculo();
            gestionTaller1.EntregarVehiculo();
            gestionTaller1.calcularRecaudacionPendiente();
            Console.ReadKey(); 
        }
    }
}
