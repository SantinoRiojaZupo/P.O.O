using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    /*4. Inventario de Sucursales 
Plantear una clase llamada Articulo que tenga como atributos privados el NombreArticulo, el Precio y el StockActual.
El constructor de la clase debe cargar estos atributos por teclado.
Confeccionar otra clase llamada Sucursal que contenga un vector de 3 objetos de la clase Articulo.
El constructor de Sucursal debe pedir el nombre o número de la sucursal y realizar la carga de los 3 artículos.
Implementar en la clase Sucursal los siguientes métodos:
Un método que imprima la lista de los artículos junto con su valor total en inventario (Precio * Stock).
Un método que busque y muestre el nombre del artículo más caro del local.
Un método que verifique e indique qué artículos de la sucursal requieren reposición urgente (aquellos cuyo stock sea menor o igual a 5 unidades).
*/
    class Articulo
    {
        private string NombreArticulo;
        private float Precio;
        private int StockActual;

        public Articulo()
        {
            Console.WriteLine("Ingrese el nombre del artículo:");
            NombreArticulo = Console.ReadLine();
            Console.WriteLine("Ingrese el precio del artículo:");
            Precio = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el stock actual del artículo:");
            StockActual = int.Parse(Console.ReadLine());
        }

        internal class Sucursal
        {
            private string SucursalActual;
            private Articulo[] articulo;
            public Sucursal()
            {
                Console.WriteLine("Ingrese el nombre o número de la sucursal:");
                SucursalActual = Console.ReadLine();
                articulo = new Articulo[3];
                for (int i = 0; i < 3; i++)
                {
                    articulo[i] = new Articulo();

                }
            }
            public void valorTotalInventario()
            {
                for (int i = 0; i < articulo.Length; i++)
                {
                    Console.WriteLine("Artículo: " + articulo[i].NombreArticulo + " Valor total en inventario: " + (articulo[i].Precio * articulo[i].StockActual));
                }
            }
            public void articuloMasCaro()
            {
                float precioMasCaro = 0;
                string nombreArticuloMasCaro = "";
                for (int i = 0; i < articulo.Length; i++)
                {
                    if (articulo[i].Precio > precioMasCaro)
                    {
                        precioMasCaro = articulo[i].Precio;
                        nombreArticuloMasCaro = articulo[i].NombreArticulo;
                    }
                }
                Console.WriteLine("El artículo más caro es: " + nombreArticuloMasCaro);
            }
            public void reposicionUrgente()
            {
                Console.WriteLine("Artículos que requieren reposición urgente:");
                for (int i = 0; i < articulo.Length; i++)
                {
                    if (articulo[i].StockActual <= 5)
                    {
                        Console.WriteLine(articulo[i].NombreArticulo);
                    }
                }
            }
            static void Main(string[] args)
            {
                Sucursal sucursal1 = new Sucursal();
                sucursal1.valorTotalInventario();
                sucursal1.articuloMasCaro();
                sucursal1.reposicionUrgente();
                Console.ReadKey();
            }
        }
    }
}