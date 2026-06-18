using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
/*1.
Confeccionar una clase llamada DispositivoEnergia que tenga como atributos privados el
CodigoIdentificador (string) y la GeneracionKwh (double, que representa los Kilowatts-hora
generados). Definir sus respectivas propiedades de lectura y escritura, validando que la
generación no sea un valor negativo (en caso de serlo, asignarle 0). Plantear un método para
imprimir estos datos básicos.
Luego, crear una segunda clase llamada PanelSolar que herede de DispositivoEnergia. Añadir
un atributo propio privado llamado AreaMetros (double, que representa la superficie del panel
en metros cuadrados) con su propiedad correspondiente (validando que sea mayor a cero).
Implementar un método para imprimir todos los datos del panel, incluyendo los heredados.
En el programa principal (Main):
● Crear un objeto de la clase DispositivoEnergia, ingresar valores y probar su impresión.
● Crear un objeto de la clase PanelSolar, cargar sus datos por consola y comprobar que
puede acceder tanto a sus propiedades heredadas como a las propias para realizar la
muestra de información.*/
{
    class DispositivoEnergia
    {
        private string codigoIdentificador;
        private double generacionKwh;

        public DispositivoEnergia() {
            Console.WriteLine("Ingrese el codigo identificador");
            codigoIdentificador = Console.ReadLine();
            Console.WriteLine("Ingrese los Kilowatts por hora generados");
            generacionKwh = double.Parse(Console.ReadLine());
            generacionKwh = (generacionKwh>=0) ? generacionKwh : 0;
        }
        public string CodigoIdentificador
        {
            get { return codigoIdentificador; }
            set { codigoIdentificador = value; }
        }
        public double GeneracionKwh
        {

            get { return generacionKwh; }
            set
            {
                generacionKwh = value;
            }
        }
        public void imprimir()
        {
            Console.WriteLine("codigo identificador:"+ codigoIdentificador);
            Console.WriteLine("generacion de kilowatts por hora:"+ generacionKwh);
        }
    }
    class PanelSolar : DispositivoEnergia
    {
        private double areaMetros;
        public PanelSolar()
        {
            Console.WriteLine("Ingrese superficie del panel en metros cuadrados");
            areaMetros = double.Parse(Console.ReadLine());
            if (areaMetros <= 0) { 
            while (areaMetros <= 0) { Console.WriteLine("Ingrese un numero mayor a 0");
                    areaMetros = double.Parse(Console.ReadLine());
                }
            }
        }
        public double AreaMetros
        {
            get { return areaMetros; }
            set { areaMetros = value; }
        }
        public void imprimirDatos()
        {
            Console.WriteLine("Area de la superficie en metros cuadrados:"+ areaMetros);
        }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            DispositivoEnergia dispositivoEnergia = new DispositivoEnergia();
            PanelSolar panelSolar = new PanelSolar();
            dispositivoEnergia.imprimir();
            panelSolar.imprimir();
            panelSolar.imprimirDatos();
            Console.ReadKey();
        }
    }
}
