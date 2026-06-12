using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Punto2
{/*2. Catálogo de Películas (Encapsulación, Validación y Composición)
Plantear una clase llamada Pelicula y otra clase llamada Catalogo.
La clase Pelicula debe tener como atributos privados: Titulo, DuracionMinutos y Calificacion (un puntaje del 1 al 5).
Definir las propiedades necesarias para acceder a estos atributos, asegurando mediante validaciones lógicas que:
 La duración en minutos sea estrictamente mayor a cero (0).
 La calificación se encuentre únicamente en el rango de 1 a 5 (de lo contrario, asignar
un valor por defecto de 1).
La clase Catalogo debe contener internamente un vector capaz de almacenar 3 objetos de
la clase Pelicula. Definir un método dentro de Catalogo para mostrar por pantalla todas las
películas ordenadas de mayor a menor en base a su duración. Además, el método debe
informar el título de la película con mejor calificación y cuál es la película más corta del
catálogo.*/
    class Pelicula
    {
        private string titulo;
        private int duracionMinutos;
        private int calificacion;
        public Pelicula(){
            Console.WriteLine("Ingrese nombre de la pelicula");
            titulo = Console.ReadLine();
            Console.WriteLine("Ingrese duracion en minutos de la pelicula, tiene que ser mayor a 0");
            duracionMinutos = int.Parse(Console.ReadLine());
            while (duracionMinutos <= 0)
            {
                Console.WriteLine("Ingrese una duracion mayor a 0");
                duracionMinutos = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ingrese calificacion entre 1 y 5, sino se pondra por default 1");
            calificacion = int.Parse(Console.ReadLine());
            if (calificacion <= 0 || calificacion > 5)
            {
                Console.WriteLine("Esta fuera del rango estandar, poniendo default");
                calificacion = 1;
            }
        }
        public string Titulo
        {
            set
            {
                titulo = value;
            }
            get { return titulo; }
        }
        public int DuracionMinutos
        {
            set { duracionMinutos = value; }
            get { return duracionMinutos;}
        }
        public int Calificacion
        {
            set { calificacion = value; 
            }
            get { return calificacion;}
        }
    }

    internal class Catalogo
    {
        Pelicula[] peliculas;
        public Catalogo() {
            peliculas = new Pelicula[3];
            for (int i = 0; i < peliculas.Length; i++) { 
            peliculas[i] = new Pelicula();
            }
        }
        public void ordenarMayorMenor()
        {
            Pelicula aux;
            aux = peliculas[0];
            Pelicula mejorCaf;
            mejorCaf = peliculas[0];
            for (int i = 0; i < peliculas.Length; i++) {
                for (int j = 0; j < peliculas.Length - 1; j++) { 
                if (peliculas[j].DuracionMinutos < peliculas[j + 1].DuracionMinutos)
                    {
                        aux = peliculas[j];
                        peliculas[j] = peliculas[j + 1];
                        peliculas [j + 1] = aux;
                    }
                }
            }
            for (int i = 1; i < peliculas.Length; i++) { 
            if (mejorCaf.Calificacion < peliculas[i].Calificacion)
                { mejorCaf=peliculas[i]; }
            }
            Console.WriteLine("Peliculas:");
            for (int i = 0; i < peliculas.Length; i++) {
                Console.WriteLine("Nombre:"+peliculas[i].Titulo+"  Duracion en minutos:" + peliculas[i].DuracionMinutos+ "  Calificacion:"+ peliculas[i].Calificacion);

            }
            Console.WriteLine();
            Console.WriteLine("Pelicual con mejor calificacion:"+ mejorCaf.Titulo);
            Console.WriteLine();
            Console.WriteLine("Pelicula mas corta del catalogo:"+ peliculas[2].Titulo);
        }
        static void Main(string[] args)
        {
            Catalogo catalogo1 = new Catalogo();
            catalogo1.ordenarMayorMenor();
            Console.ReadKey();
        }
    }
}
