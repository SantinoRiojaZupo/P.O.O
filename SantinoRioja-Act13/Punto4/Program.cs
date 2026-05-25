using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{/*4. Plantear una clase Alumno que tenga los atributos privados: nombre y un vector de 4 notas.
Definir un constructor que solicite el ingreso del nombre del alumno y sus 4 calificaciones.
Luego, confeccionar una clase Curso que contenga un vector de 3 objetos Alumno.
Agregar los siguientes métodos:
a) Un método que imprima el nombre de cada alumno y su promedio.
b) Un método que muestre el nombre del alumno con el promedio más
alto.
c) Un método que indique qué alumnos tienen al menos una nota
desaprobada (nota menor a 6)*/
    class alumno
    {
        private string nombre;
        private float[] notas = new float[4];
        public alumno()
        {
            Console.WriteLine("Ingrese el nombre del alumno");
            nombre = Console.ReadLine();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Ingrese la nota " + (i));
                notas[i] = float.Parse(Console.ReadLine());
                if (notas[i] < 0 || notas[i] > 10)
                {
                    Console.WriteLine("Nota inválida. Ingrese una nota entre 0 y 10.");
                    i--;
                }
            }
        }
        public string devolverNombre()
        {
            return nombre;

        }
        public float devolverPromedio()
        {
            float promedio = 0;
            for (int i = 0; i < 4; i++)
            {
                promedio += notas[i];
            }
            return promedio / 4;
        }
        public float[] devolverNotas()
        {
            return notas;
        }
    }
    internal class Curso
    {
        private alumno alumno1, alumno2, alumno3;
        public Curso()
        {
            alumno1 = new alumno();
            alumno2 = new alumno();
            alumno3 = new alumno();
        }
        public void imprimirPromedios()
        {
            Console.WriteLine("Alumno: " + alumno1.devolverNombre() + " Promedio: " + alumno1.devolverPromedio());
            Console.WriteLine("Alumno: " + alumno2.devolverNombre() + " Promedio: " + alumno2.devolverPromedio());
            Console.WriteLine("Alumno: " + alumno3.devolverNombre() + " Promedio: " + alumno3.devolverPromedio());
        }
        public void alumnoConPromedioMasAlto()
        {
            float promedio1 = alumno1.devolverPromedio();
            float promedio2 = alumno2.devolverPromedio();
            float promedio3 = alumno3.devolverPromedio();
            if (promedio1 > promedio2 && promedio1 > promedio3)
            {
                Console.WriteLine("El alumno con el promedio más alto es: " + alumno1.devolverNombre());
            }
            else if (promedio2 > promedio1 && promedio2 > promedio3)
            {
                Console.WriteLine("El alumno con el promedio más alto es: " + alumno2.devolverNombre());
            }
            else
            {
                Console.WriteLine("El alumno con el promedio más alto es: " + alumno3.devolverNombre());
            }
        }
        public void alumnosNotaDesaprobada()
        { 
            float[] nota1 = new float[4];
            float[] nota2 = new float[4];
            float[] nota3 = new float[4];
            bool alumno1Desaprobado = false;
            bool alumno2Desaprobado = false;
            bool alumno3Desaprobado = false;
            for (int i = 0; i < 4; i++)
            {
                 nota1[i] = alumno1.devolverNotas()[i];
                 nota2[i] = alumno2.devolverNotas()[i];
                 nota3[i] = alumno3.devolverNotas()[i];
                if (nota1[i]<6)
                {
                    alumno1Desaprobado = true;
                }
                if (nota2[i]<6)
                {
                    alumno2Desaprobado = true;
                }
                if (nota3[i]<6)
                {
                    alumno3Desaprobado = true;
                }
            }
            if (alumno1Desaprobado==true)
            {
                Console.WriteLine("El alumno " + alumno1.devolverNombre() + " tiene al menos una nota desaprobada.");
            }
            if (alumno2Desaprobado==true)
            {
                Console.WriteLine("El alumno " + alumno2.devolverNombre() + " tiene al menos una nota desaprobada.");
            }
            if (alumno3Desaprobado==true)
            {
                Console.WriteLine("El alumno " + alumno3.devolverNombre() + " tiene al menos una nota desaprobada.");
            }
        }
        static void Main(string[] args)
        {
            Curso curso1 = new Curso();
            curso1.imprimirPromedios();
            curso1.alumnoConPromedioMasAlto();
            curso1.alumnosNotaDesaprobada();
            Console.ReadKey();
        }
    }
}
