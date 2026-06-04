using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{ /*3. Geolocalización de Reservas Naturales
Un centro de ecología realiza mapeos de biodiversidad para contabilizar el avistamiento de
especies protegidas en cuadrículas de territorio.
● Confeccionar la clase ReservaNatural que tenga como atributos privados el
NombreReserva y una matriz llamada avistamientos de 3x3 (que representa un
mapa de coordenadas o sectores de 3 filas y 3 columnas, donde se almacena la
cantidad de animales avistados en cada sector). El constructor de la clase debe
cargar por teclado el nombre y rellenar el mapa de avistamientos.
● Confeccionar la clase colaboradora CentroEcologico que contenga un vector de 3
objetos de la clase ReservaNatural.
La clase CentroEcologico debe implementar los siguientes métodos:
1. Un constructor que solicite la carga secuencial de las 3 reservas.
2. Un método que enliste cada reserva junto a la cantidad total de avistamientos que
registró en toda su superficie (la suma de toda su matriz rectangular).
3. Un método que determine e informe cuál fue la coordenada o sector específico ([fila,
columna]) que registró la mayor concentración de avistamientos de toda la red de
reservas, indicando a qué reserva pertenece.*/
    class ReservaNatural
    {
        private string NombreReserva;
        private int[,] avistamientos = new int[3, 3];

        public ReservaNatural()
        {
            Console.WriteLine("Ingrese el nombre de la reserva natural:");
            NombreReserva = Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Ingrese la cantidad de avistamientos en la coordenada [{i},{j}]:");
                    avistamientos[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public string DevolverNombre()
        {
            return NombreReserva;
        }

        public int[,] DevolverAvistamientos()
        {
            return avistamientos;
        }
    }
    internal class CentroEcologico
    {
        private ReservaNatural[] reservas = new ReservaNatural[3];
        public CentroEcologico()
        {
            for (int i = 0; i < reservas.Length; i++)
            {
                reservas[i] = new ReservaNatural();
            }
        }
        public void ListarReservas()
        {
            
            for (int i = 0; i < 3; i++)
            {
                int totalAvistamientos = 0;
                Console.WriteLine(reservas[i].DevolverNombre());
                int[,] avistamientos = reservas[i].DevolverAvistamientos();
                for (int j = 0; j < avistamientos.GetLength(0); j++)
                {
                    for (int k = 0; k < avistamientos.GetLength(1); k++)
                    {
                        totalAvistamientos += avistamientos[j, k];
                    }
                }
                Console.WriteLine("Total Avistamientos:"+ totalAvistamientos);
            }
        }
        public void MayorConcentracion()
        {
            int mayorAvistamientos = 0;
            string reservaMayor = "";
            int filaMayor = 0;
            int columnaMayor = 0;
            for (int i = 0;i < 3;i++)
            {
                int[,] avistamientos = reservas[i].DevolverAvistamientos();
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (avistamientos[j, k] > mayorAvistamientos)
                        {
                            mayorAvistamientos = avistamientos[j, k];
                            filaMayor = j;
                            columnaMayor = k;
                            reservaMayor = reservas[i].DevolverNombre();
                        }
                    }
                }
            }
            Console.WriteLine("La mayor concentración de avistamientos se encuentra en la reserva "+ reservaMayor +" en la coordenada ["+ filaMayor+","+ columnaMayor+ "] con "+ mayorAvistamientos+" avistamientos.");
        }
        static void Main(string[] args)
        {
            CentroEcologico centro1 = new CentroEcologico();
            centro1.ListarReservas();
            centro1.MayorConcentracion();
            Console.ReadKey();
        }
    }
}
