using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Temperatura
    {
        //1. Se desea saber la temperatura media trimestral de cuatro paises.
        //Para ello se tiene como dato las temperaturas medias mensuales de dichos paises.
        //Se pide ingresar el nombre del país y seguidamente las tres temperaturas medias mensuales.
        //Seleccionar las estructuras de datos adecuadas para el almacenamiento de los datos en memoria.
        //a.Cargar por teclado los nombres de los paises y las temperaturas medias mensuales.
        //b.Imprimir los nombres de las paises y las temperaturas medias mensuales de las mismas.
        //c.Calcular la temperatura media trimestral de cada país.
        //d.Imprimir los nombres de los paises y las temperaturas medias trimestrales.
        //e.Imprimir el nombre del país con la temperatura media trimestral mayor.
        private string[] paises;
        private float[,] tempMedias;
        private float[] tempTrimestral;

        public void cargar()
        {
            paises = new string[4];
            tempMedias = new float[4, 3];
            tempTrimestral = new float[4];

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Ingrese el nombre del pais en la posicion:" + i);
                paises[i] = Console.ReadLine();
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("ingrese la temperatua media del mes nro:"+ j);
                    tempMedias[i,j]= float.Parse(Console.ReadLine());
                }

            }
        }
        public void imprimir()
        {
            for (int i = 0; i < 4; i++) {
                Console.WriteLine("Pais:" + paises[i]+ " Temperaturas medias:");
                for (int j = 0; j < 3; j++) {
                    Console.WriteLine(tempMedias[i,j]);
                }
            }
        }
        public void calcTrim()
        {
            for (int i = 0; i < 4; i++) {
                for (int j = 0; j < 3; j++)
                {
                    tempTrimestral[i] += tempMedias[i, j];
                }
                tempTrimestral[i] = (tempTrimestral[i]/3);
              }
        }
        public void impTrim() {
            for (int i = 0; i < 4; i++) {
                Console.WriteLine("Pais:" + paises[i]+ " Temperatura media trimestral:" + tempTrimestral[i]);
            }
        }
        public void impMayor()
        {
            float mayor = tempTrimestral[0];
            string mayorNombre = paises[0];
            for (int i = 0; i < 4; i++)
            {
                if (mayor < tempTrimestral[i])
                {
                    mayor=tempTrimestral[i];
                    mayorNombre=paises[i];
                }
            }
            Console.WriteLine("El pais con la temperatura media trimestral mayor es:"+ mayorNombre);
        }
        static void Main(string[] args)
        {
            Temperatura temperatura1 = new Temperatura();
            temperatura1.cargar();
            temperatura1.imprimir();
            temperatura1.calcTrim();
            temperatura1 .impTrim();
            temperatura1.impMayor();
            Console.ReadKey();
        }
    }
}
