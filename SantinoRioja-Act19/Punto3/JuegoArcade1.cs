using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    partial class JuegoArcade
    {
        protected string nombreJuego;
        protected int puntajeMaximo, nivelDificultad;
        public JuegoArcade()
        {
            Console.WriteLine("Ingrese el nombre del juego");
            nombreJuego = Console.ReadLine();
            Console.WriteLine("Ingrese el puntaje maximo del juego");
            puntajeMaximo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nivel de dificultad del 1 al 5");
            nivelDificultad = int.Parse(Console.ReadLine());
            while (nivelDificultad<1||nivelDificultad>5)
            {
                Console.WriteLine("Ingrese un nivel de dificultad valido");
                nivelDificultad = int.Parse(Console.ReadLine());
            }
        }
        public string NombreJuego
        {
            get { return nombreJuego; }
            set { nombreJuego = value; }
        }
        public int NivelDificultad
        {
            get { return nivelDificultad; }
            set { nivelDificultad = value; }
        }
        public int PuntajeMaximo
        {
            get { return puntajeMaximo; }
            set { puntajeMaximo = value; }
        }
    }
}
