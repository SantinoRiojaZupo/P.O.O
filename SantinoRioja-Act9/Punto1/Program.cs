using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Notas
        //1. Se desea desarrollar un programa que permita registrar los nombres y las calificaciones de 6 estudiantes.
        //Luego de cargar los datos, se debe mostrar el nombre del estudiante con la nota más alta, junto con su nota.
        //Al igual que el estudiante con la nota más baja.Informar si hay estudiantes con la misma nota máxima o mínima.
        
    {
        private int[] notas;
        private string[] alumnos;
        private int notaMax, notaMin;
        private int[] notasMax, notasMin;
        private string[] alumnosMax, alumnosMin;
        
        

        public void cargar()
        {
            notas = new int[6];
            alumnos = new string[6];
            for(int i = 0; i < 6; i++)
            {
                Console.WriteLine("ingrese nombre del alumno en posicion: " + (i + 1));
                alumnos[i]= Console.ReadLine();
                Console.WriteLine("ingrese nota de "+alumnos[i]+ ":");
                notas[i] = int.Parse(Console.ReadLine());
            }
        }
        public void conseguirMaxMin()
        {
            notaMax = notas[0];
            notaMin = notas[0];
            for (int i = 1; i < 6; i++)
            {
                if (notas[i] > notaMax)
                { notaMax = notas[i];}
                if (notas[i] < notaMin)
                {  notaMin = notas[i];}
            }
        }
        public void cargarMaxMin()
        {
            int notasMaxCant = 0, notasMinCant = 0, j = 0, u = 0; ;
            for (int i = 0;i < 6; i++)
            {
                if (notaMax == notas[i]) { notasMaxCant++; }
                if (notaMin == notas[i]) { notasMinCant++; }
            }
            notasMax = new int[notasMaxCant];
            notasMin = new int[notasMinCant];
            alumnosMax = new string[notasMaxCant];
            alumnosMin = new string[notasMinCant];
            for (int i = 0; i<6; i++)
            {
                if (notaMax == notas[i])
                { notasMax[j]=notaMax;
                    alumnosMax[j] = alumnos[i];
                    j++;
                }
                if (notaMin==notas[i])
                { notasMin[u]=notaMin;
                 alumnosMin[u] = alumnos[i];
                    u++;
                }
                
            }
        }
        public void mostrarAlumnos(){
            for (int i = 0; i < alumnosMax.Length; i++)
            {
                    Console.WriteLine("Alumno/s con nota mas alta: " + alumnosMax[i]+ " Nota:" + notasMax[i]);
            }
            for (int i = 0;i<alumnosMin.Length ; i++)
            {
                Console.WriteLine("Alumno/s con nota mas baja: "+ alumnosMin[i] +  " Nota:" + notasMin[i]);
            }
            Console.WriteLine("Hay " + alumnosMax.Length + " alumno/s con la nota mas alta");
            Console.WriteLine("Hay " + alumnosMin.Length + " alumno/s con la nota mas baja");
        }
        static void Main(string[] args)
        {
            Notas notas1 = new Notas();
            notas1.cargar();
            notas1.conseguirMaxMin();
            notas1.cargarMaxMin();
            notas1.mostrarAlumnos();
            Console.ReadKey();
        }
    }
}
