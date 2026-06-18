using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
    /*2.
Plantear una clase llamada CriaturaMarina y otra clase llamada HabitatAcuatico.
La clase CriaturaMarina debe tener como atributos privados: Especie (string),
ProfundidadOptima (int, en metros) y NivelSalinidad (un valor de 1 a 100). Definir las
propiedades necesarias para acceder a estos atributos asegurando mediante validaciones que:
● La profundidad óptima sea estrictamente mayor a cero (0).
● El nivel de salinidad se encuentre únicamente en el rango de 1 a 100 (de lo contrario,
asignar un valor por defecto de 35, que representa la salinidad promedio del océano).
La clase HabitatAcuatico debe contener como atributo un vector capaz de almacenar 3 objetos
de la clase CriaturaMarina. Definir un método dentro de HabitatAcuatico para cargar las 3
criaturas y otro método para mostrar todas las criaturas ordenadas de menor a mayor en base
a su profundidad óptima. Además, el programa debe informar la especie que requiere el mayor
nivel de salinidad para sobrevivir.*/
{
    class CriaturaMarina
    {
        private string especie;
        private int profundidadOptima;
        private int nivelSalinidad;
        public CriaturaMarina()
        {
            Console.WriteLine("Ingrese nombre de la especie");
            especie = Console.ReadLine();
            Console.WriteLine("Ingrese la profundidad optima en metros");
            profundidadOptima = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nivel de salinidad del 1 a 100");
            nivelSalinidad = int.Parse(Console.ReadLine());
            if (profundidadOptima <= 0) { while (profundidadOptima <= 0) { Console.WriteLine("La profundidad optima tiene que ser mayor a 0");
                profundidadOptima = int.Parse(Console.ReadLine());} }
            nivelSalinidad = (nivelSalinidad > 0 && nivelSalinidad < 101) ? nivelSalinidad : 35;
        }
        public string Especie
        {
            get { return especie; }
            set { especie = value; }
        }
        public int ProfundidadOptima
        {
            get { return profundidadOptima; }
            set { profundidadOptima = value; }
        }
        public int NivelSalinidad
        {
            get { return nivelSalinidad; }
            set { nivelSalinidad = value; }
        }
    }
    internal class HabitatAcuatico
    {
        CriaturaMarina[] criaturasMarinas;
        public HabitatAcuatico() { criaturasMarinas = new CriaturaMarina[3];
            for (int i = 0; i < 3; i++) { 
            criaturasMarinas[i] = new CriaturaMarina();
            }
        }
        public void cargarCriaturas() {
            for (int i = 0; i < 3; i++) {
                Console.WriteLine("Criatura numero "+i);
                Console.WriteLine("Especie:" + criaturasMarinas[i].Especie);
                Console.WriteLine("Profundiad optima:"+ criaturasMarinas[i].ProfundidadOptima);
                Console.WriteLine("Nivel Salinidad:" + criaturasMarinas[i].NivelSalinidad);
            }
        }
        public void criaturasMenorMayor()
        {
            CriaturaMarina criaturaAux;
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 2; j++) {
                    if (criaturasMarinas[j].ProfundidadOptima > criaturasMarinas[j + 1].ProfundidadOptima)
                    {
                        criaturaAux = criaturasMarinas[j];
                        criaturasMarinas[j] = criaturasMarinas[j + 1];
                        criaturasMarinas[j + 1] = criaturaAux;
                    }
                }
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Criatura numero " + i);
                Console.WriteLine("Especie:" + criaturasMarinas[i].Especie);
                Console.WriteLine("Profundiad optima:" + criaturasMarinas[i].ProfundidadOptima);
                Console.WriteLine("Nivel Salinidad:" + criaturasMarinas[i].NivelSalinidad);
            }
        }
        public void masSalinidad()
        {
            string salEsp = criaturasMarinas[0].Especie;
            int salProf = criaturasMarinas[0].ProfundidadOptima;
            int salNivelSalinidad = criaturasMarinas[0].NivelSalinidad;
            for (int i = 1; i < 3; i++) { 
            if (criaturasMarinas[i].NivelSalinidad > salNivelSalinidad)
                {
                     salEsp = criaturasMarinas[i].Especie;
                     salProf = criaturasMarinas[i].ProfundidadOptima;
                     salNivelSalinidad = criaturasMarinas[i].NivelSalinidad;
                }
            }
            Console.WriteLine("La especie que requiere el mayor nivel de salinidad es:"+salEsp);
        }
        static void Main(string[] args)
        {
            HabitatAcuatico habitatAcuatico1 = new HabitatAcuatico();
            habitatAcuatico1.cargarCriaturas();
            habitatAcuatico1.criaturasMenorMayor();
            habitatAcuatico1.masSalinidad();
            Console.ReadKey();
        }
    }
}
