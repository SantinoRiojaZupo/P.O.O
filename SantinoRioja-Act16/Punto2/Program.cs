using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    /*2. Plantear una clase Producto y otra clase Inventario.
La clase Producto debe tener como atributos privados el nombre, precio y
stock. Definir propiedades para acceder a estos atributos, asegurando que el
stock no pueda ser negativo y el precio sea mayor a cero.
La clase Inventario debe contener 3 objetos de la clase Producto. Definir un
método para mostrar todos los productos ordenados de menor a mayor en
base al precio, además, mostrar el producto más caro y más barato del
inventario.*/
    class Producto {
        private string nombre;
        private float precio;
        private int stock;
        public string Nombre {  
        set {nombre = value;}
            get {return nombre;}
        }
        public float Precio
        {
            set {

                    precio = value; }
            

            get {return precio;}

        }
        public int Stock
        {
            set { 
             stock = value;
                }
            get {return stock;}
        }       
    }
    
    internal class Inventario
       
    {
        Producto[] productos;
        public Inventario() {
             productos = new Producto[3];
            for (int i=0;i< productos.Length; i++)
            {
                productos[i] = new Producto();
                Console.WriteLine("Ingrese el nombre del producto" + i);
                productos[i].Nombre=Console.ReadLine();
                Console.WriteLine("Ingrese el precio del producto" + i+ ", no puede ser 0 o menos");
                productos[i].Precio =float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad del stock, no puede ser menor a 0");
                productos[i].Stock = int.Parse(Console.ReadLine());
                if (productos[i].Precio<=0 || productos[i].Stock<0)
                { Console.WriteLine("Ingrese correctamente los datos"); 
                    i--; }
            }
        }
        public void ordenarMenorMayor()
        {
            Producto auxiliar = new Producto();
            for (int j = 0; j < productos.Length; j++)
            {
                for (int i = 0; i < productos.Length-1; i++)
                {
                    if (productos[i].Precio > productos[i + 1].Precio)
                    {
                        auxiliar = productos[i];
                        productos[i] = productos[i + 1];
                        productos[i + 1] = auxiliar;
                    }
                }
            }
            for (int i = 0; i<3; i++)
            {
                Console.WriteLine("Producto:" + productos[i].Nombre + " Precio:"+ productos[i].Precio+ " Stock:"+ productos[i].Stock);
            }
        }
        public void masCaro()
        {
            Console.WriteLine("El producto mas caro es:"+ productos[2].Nombre+ " Con el precio de :"+ productos[2].Precio);
        }
        public void masBarato()
        {
            Console.WriteLine("El producto mas barato es:"+ productos[0].Nombre+ " Con el precio de :" +productos[0].Precio);
        }
  
        static void Main(string[] args)
        {Inventario inventario1 = new Inventario();
            inventario1.ordenarMenorMayor();
            inventario1.masCaro();
            inventario1.masBarato();
            Console.ReadKey();
        }
    }
}
