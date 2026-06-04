using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_1
{/*1. Monitoreo Clínico de Pacientes
En una sala de cuidados intensivos, se requiere realizar un seguimiento constante del ritmo cardíaco de los pacientes.
● Plantear una clase llamada Paciente que tenga como atributos privados:
1. Nombre (de tipo string).
2. Una matriz llamada ritmoCardiaco de tamaño 3x4
(representando los registros de pulsaciones tomados durante 3 días diferentes, en 4 momentos clave de cada día: mañana, mediodía, tarde y noche).
3. El constructor de Paciente debe pedir su nombre y solicitar la carga por teclado de las 12 lecturas cardíacas.

● Confeccionar la clase colaboradora SalaMonitoreo que administre un vector de 3 objetos de la clase Paciente.
Su constructor debe inicializar el vector y solicitar la carga de los 3 pacientes.
Implementar los siguientes métodos dentro de SalaMonitoreo:
1. Un método que imprima la grilla de lecturas cardíacas completa de cada paciente organizada por día y momento.
2. Un método que calcule e imprima el promedio de pulsaciones de cada paciente a lo largo de todo su monitoreo.
3. Un método que verifique si algún paciente registró un evento de taquicardia severa
(cualquier lectura individual que sea estrictamente mayor a 120 pulsaciones), mostrando por consola su nombre y la lectura detectada.*/

    class Pacientes
    {
        private string Nombre;
        private int[,] ritmoCardiaco;

        public Pacientes()
        {
            ritmoCardiaco = new int[3, 4];
            Console.WriteLine("Ingrese el nombre del paciente");
            Nombre = Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++) {
                    string momento ="";
                    if (j == 0) { momento = "mañana"; }
                    if (j == 1) { momento = "mediodia"; }
                    if (j == 2) { momento = "tarde"; }
                    if (j == 3) { momento = "noche"; }
                    Console.WriteLine("Ingrese la lectura cardiaca del Dia:" + i + " momento:"+ momento);
                    ritmoCardiaco[i,j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public string devolverNombre()
        {
            return Nombre;
        }
        public int[,] devolverGrilla()
            { return ritmoCardiaco; }
    }
    internal class salaMonitoreo
        

    {
        private Pacientes[] paciente;
        public salaMonitoreo() { 
        paciente = new Pacientes [3];
            for (int i = 0; i < 3; i++)
            {
                paciente[i] = new Pacientes();
            }
        }
        public void imprimirGrillas()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Nombre:"+ paciente[i].devolverNombre() + " Grilla:");
                int[,] grilla = paciente[i].devolverGrilla();
                for (int k = 0; k < 3; k++)
                {
                    Console.WriteLine("Dia: "+ k);
                    for (int j = 0; j < 4; j++)
                    {

                        string momento = "";
                        if (j == 0) { momento = "mañana"; }
                        if (j == 1) { momento = "mediodia"; }
                        if (j == 2) { momento = "tarde"; }
                        if (j == 3) { momento = "noche"; }
                        Console.WriteLine(momento+" "+ grilla[k, j] + "");
                    }
                }
            }
        }
        public void calcularPromedio()
        {
            for (int i = 0; i < 3; i++)
            {
                int suma = 0;
                int[,] grilla = paciente[i].devolverGrilla();
                for (int k = 0; k < 3; k++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        suma += grilla[k, j];
                    }
                }
                Console.WriteLine("El promedio de pulsaciones del paciente " + paciente[i].devolverNombre() + " es: " + (suma / 12));
            }
        }
        public void taquicardia()
        {
            for (int i = 0; i < 3; i++)
            {
                int[,] grilla = paciente[i].devolverGrilla();
                for (int k = 0; k < 3; k++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (grilla[k, j] > 120)
                        {
                            string momento = "";
                            if (j == 0) { momento = "mañana"; }
                            if (j == 1) { momento = "mediodia"; }
                            if (j == 2) { momento = "tarde"; }
                            if (j == 3) { momento = "noche"; }
                            Console.WriteLine("El paciente " + paciente[i].devolverNombre() + " registró un evento de taquicardia severa en el dia: " + k + " momento: " + momento + " con una lectura de: " + grilla[k, j]);
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            salaMonitoreo salaMonitoreo1 = new salaMonitoreo();
            salaMonitoreo1.imprimirGrillas();
            salaMonitoreo1.calcularPromedio();
            salaMonitoreo1.taquicardia();
            Console.ReadKey();
        }
    }
}
