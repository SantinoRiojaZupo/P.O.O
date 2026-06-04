using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{ /*4. Línea de Ensamblaje Robótico
En una planta de fabricación automatizada, cada robot industrial realiza tareas de
ensamblaje complejas divididas en operaciones secundarias de duración variable.
● Diseñar la clase RobotEnsamblador que tenga como atributos privados:
1. ModeloRobot.
2. Una matriz irregular de tipo float (float[][] tiemposOperacion) donde cada
fila representa una de las 4 fases principales del proceso (Estructura,
Cableado, Pintura y Testeo), y cada columna los segundos que demoró en
completar las distintas subtareas de esa fase (por ejemplo, en la fase de
Estructura el robot puede tener 3 sub-tareas, pero en la de Testeo solo tiene
1).
3. El constructor de RobotEnsamblador debe pedir su modelo, preguntar para
cada una de las 4 fases de fabricación cuántas sub-tareas requirió realizar

(definiendo el tamaño de cada fila) y cargar la duración en segundos de cada
una de ellas.

● Diseñar la clase colaboradora PlantaIndustrial que gestione a 3 objetos de la clase
RobotEnsamblador. Implementar en PlantaIndustrial:
1. Un constructor que cargue la información de los 3 robots instalados en la
planta.
2. Un método que muestre un reporte detallado con los tiempos de operación
de cada robot fase por fase.
3. Un método que calcule el promedio general de tiempo por tarea de cada
robot y declare al Robot más Eficiente (aquel que registre el promedio de
tiempo por operación más bajo de la planta).*/
    class RobotEnsamblador
    {
        private string ModeloRobot;
        float[][] tiemposOperacion;
        public RobotEnsamblador()
        {
            tiemposOperacion = new float[4][];
            Console.WriteLine("Ingrese el modelo del robot:");
            ModeloRobot = Console.ReadLine();
            string[] fases = { "Estructura", "Cableado", "Pintura", "Testeo" };
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Ingrese la cantidad de sub-tareas para la fase"+ fases[i]);
                int cantidadSubTareas = int.Parse(Console.ReadLine());
                tiemposOperacion[i] = new float[cantidadSubTareas];
                for (int j = 0; j < cantidadSubTareas; j++)
                {
                    Console.WriteLine("Ingrese la duración en segundos de la sub-tarea "+ j+" de la fase"+ fases[i]);
                    tiemposOperacion[i][j] = float.Parse(Console.ReadLine());
                }
            }
        }
        public string DevolverModelo()
        {
            return ModeloRobot;
        }
        public float[][] DevolverTiempos()
        {
            return tiemposOperacion;
        }

    }
    internal class PlantaIndustrial
    {
        private RobotEnsamblador[] robots = new RobotEnsamblador[3];
        public PlantaIndustrial()
        {
            for (int i = 0; i < robots.Length; i++)
            {
                robots[i] = new RobotEnsamblador();
            }
        }
        public void MostrarReporte()
        {
            string[] fases = { "Estructura", "Cableado", "Pintura", "Testeo" };
            for (int i = 0; i < robots.Length; i++)
            {
                Console.WriteLine("Robot: "+ robots[i].DevolverModelo());
                float[][] tiempos = robots[i].DevolverTiempos();
                for (int j = 0; j < tiempos.Length; j++)
                {
                    Console.WriteLine("Fase: "+ fases[j]);
                    for (int k = 0; k < tiempos[j].Length; k++)
                    {
                        Console.WriteLine("Sub-tarea "+ k+" : "+ tiempos[j][k]+" segundos");
                    }
                }
            }
        }
        public void masEficiente() { 
         float tiempo1=0;
        float    tiempo2=0;
        float    tiempo3=0;
            for (int i = 0; i < robots.Length; i++)
            {
                float[][] tiempos = robots[i].DevolverTiempos();
                for (int j = 0; j < tiempos.Length; j++)
                {
                    for (int k = 0; k < tiempos[j].Length; k++)
                    {
                        if (i == 0) { tiempo1 += tiempos[j][k]; }
                        if (i == 1) { tiempo2 += tiempos[j][k]; }
                        if (i == 2) { tiempo3 += tiempos[j][k]; }
                    }
                }
                if (i == 0) { tiempo1 = tiempo1 / tiempos.Length; }
                if (i == 1) { tiempo2 = tiempo2 / tiempos.Length; }
                if (i == 2) { tiempo3 = tiempo3 / tiempos.Length; }
            }
            if (tiempo1 < tiempo2 && tiempo1 < tiempo3) { Console.WriteLine("El robot mas eficiente es: " + robots[0].DevolverModelo() + " con un promedio de tiempo por tarea de: " + tiempo1); }
            if (tiempo1 > tiempo2 && tiempo2 < tiempo3) { Console.WriteLine("El robot mas eficiente es: " + robots[1].DevolverModelo() + " con un promedio de tiempo por tarea de: " + tiempo2); }
            if (tiempo3 < tiempo2 && tiempo1 > tiempo3) { Console.WriteLine("El robot mas eficiente es: " + robots[2].DevolverModelo() + " con un promedio de tiempo por tarea de: " + tiempo3); }
        }

    
    
        static void Main(string[] args)
        {
            PlantaIndustrial plantaIndustrial1 = new PlantaIndustrial();
            plantaIndustrial1.MostrarReporte();
            plantaIndustrial1.masEficiente();
            Console.ReadKey();
        }
    }
}
