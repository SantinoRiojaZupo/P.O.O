using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Empresa
    {/*1. Sistema de Logística: Envíos por Sucursal
Una empresa de correo tiene 3 sucursales principales.Cada sucursal procesa una
cantidad diferente de paquetes por día dependiendo de su demanda.
● Definir un vector de tipo string para los nombres de las 3 sucursales.
● Definir una matriz irregular donde cada fila sea una sucursal y cada columna
represente el peso (en kg) de cada paquete enviado.
● Métodos:
1. Cargar los nombres de las sucursales y, para cada una, preguntar cuántos
paquetes se enviaron hoy para definir el tamaño de su fila.
2. Cargar el peso de cada paquete.
3. Imprimir el peso de todos los paquetes organizados por sucursal.
4. Calcular e informar el peso total despachado por cada sucursal.
5. Informar cuál es el paquete más pesado de toda la empresa y a qué sucursal
pertenece.*/
        private string[] sucursales;
        private float[][] prodsKg;

        public void crear() {
            sucursales = new string[3];
            prodsKg = new float[3][];
            for (int i = 0; i < sucursales.Length; i++)
            {
                Console.WriteLine("Cuantos paquetes envio hoy la empresa nro:"+i+"?");
                prodsKg[i] = new float[int.Parse(Console.ReadLine())];
            }
            
        }
        public void cargar()
        {
            for (int i = 0;i < sucursales.Length;i++)
            {
                Console.WriteLine("Ingrese el nombre de la sucursal nro:"+i);
                sucursales[i] = Console.ReadLine();

                for (int j = 0; j < prodsKg[i].Length; j++) {
                    Console.WriteLine("Ingrese el peso del paquete nro:"+j+ " De la sucursal:"+ sucursales[i]+" Ingrsar en KG");
                    prodsKg[i][j]= float.Parse(Console.ReadLine());
                }
            }

        }
        public void impPeso()
        {
            for (int i = 0; i < sucursales.Length; i++)
            {
                Console.WriteLine("Sucursal:" + sucursales[i]+ "   Peso productos: ");
                for (int j = 0; j < prodsKg[i].Length; j++)
                {
                    Console.WriteLine(prodsKg[i][j]);
                }
            }
        }
        public void pesoTotal()
        {
            
                for (int i = 0; i < sucursales.Length; i++)
                {
                    float total = 0;
                    Console.WriteLine("Sucursal:" + sucursales[i] + "   Peso productos total: ");
                    for (int j = 0; j < prodsKg[i].Length; j++)
                    {
                        total+= prodsKg[i][j];
                    }
                    Console.WriteLine(total+"KG");
                }
            
        }
        public void masPeso()
        {
            float pesado = 0;
            int pesadoFila = 0;
                int pesadoColumna = 0;
                for (int i = 0; i < sucursales.Length; i++)
                {
                    
                    for (int j = 0; j < prodsKg[i].Length; j++)
                    {
                       if (pesado< prodsKg[i][j])
                    {
                        pesado = prodsKg[i][j];
                        pesadoFila = i;
                        pesadoColumna = j;
                    }
                    }
                }
            Console.WriteLine("El producto mas pesado de la empresa es el Nro:"+pesadoColumna+ " De la sucursal "+ sucursales[pesadoFila] + " pesando "+ prodsKg[pesadoFila][pesadoColumna]+" KG");
        }
        static void Main(string[] args)
        {
            Empresa empresa1 = new Empresa();
            empresa1.crear();
            empresa1.cargar();
            empresa1.impPeso();
            empresa1.pesoTotal();
            empresa1.masPeso();
            Console.ReadKey();
        }
    }
}
