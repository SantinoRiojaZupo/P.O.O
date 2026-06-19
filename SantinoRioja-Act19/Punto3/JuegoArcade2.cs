using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    partial class JuegoArcade
    {
       public string nombreJugador;
       public int puntaje;
       public bool superoRecord=false;
        public void Partida()
        {
            Console.WriteLine("Ingrese su puntaje");
            puntaje = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre del jugador");
            nombreJugador = Console.ReadLine();
            if (puntaje > PuntajeMaximo)
            {
                Console.WriteLine("El puntaje ingresado supera el record de su juego");
                superoRecord = true;
            }
            else {
                Console.WriteLine("El puntaje ingresado no supera el record de su juego");
            }
        }
    }
}
