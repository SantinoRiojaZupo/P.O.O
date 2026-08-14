using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    /*9-
Un instituto de enseñanza registra de forma dinámica a sus estudiantes para
realizar el seguimiento académico de sus materias.
 Crear la clase Estudiante que contenga como atributos privados:
nombreCompleto (string) y calificacion (double). Definir sus propiedades
de solo lectura y un constructor que reciba nom y cal.
 Crear la clase GestionAcademica que administre una lista de objetos
List.
 Métodos en GestionAcademica:
o CargarEstudiantes(): Solicitar por teclado nombres y
calificaciones para agregar estudiantes a la lista mediante .Add(). La
carga finaliza cuando el usuario ingresa la palabra &quot;FIN&quot; como
nombre.
o ListarEstudiantes(): Mostrar en pantalla todos los alumnos
junto a la cantidad total de inscriptos mediante la propiedad .Count.
o FiltrarAprobados(): Recorrer la lista e imprimir en consola
únicamente aquellos estudiantes cuya calificación sea mayor o igual
a 6.0.
o DarDeBaja(): Pedir al operador el nombre de un estudiante y,
utilizando los métodos de búsqueda y remoción de listas, eliminarlo
de la colección si se encuentra presente.*/
    class Estudiante
    {
        private string nombreCompleto;
        private double calificacion;
        public string NombreCompleto
        {
            get { return nombreCompleto; }
            set { nombreCompleto = value; }
        }
        public double Calificacion
        {
            get { return calificacion; }
            set { calificacion = value; }
        }
        public Estudiante(string nom,double cal)
        {
            nombreCompleto = nom;
            calificacion = cal;
        }
    }
    class GestionAcademica
    {
        List<Estudiante> estudiantes = new List<Estudiante>();
        public void CargarEstudiantes()
        {
            string nom;
            double cal = 0;
            bool bucle = true;
            while (bucle == true)
            {
                Console.WriteLine("Ingrese el nombre del estudiante o FIN si quiere finalizar la carga");
                nom = Console.ReadLine();
                if (nom == "FIN")
                {
                    bucle = false;
                    break;
                }
                Console.WriteLine("Ingrese su Calificacion");
                cal = double.Parse(Console.ReadLine());
                estudiantes.Add(new Estudiante(nom, cal));
            }
        }
        public void ListarEstudiantes()
        {
            Console.WriteLine("Listado de estudiantes:");
            foreach (Estudiante estudiante in estudiantes)
            {
                Console.WriteLine("Nombre:"+estudiante.NombreCompleto+ "   Calificacion:"+estudiante.Calificacion);
            }
            Console.WriteLine("Cantidad de estudiantes:"+ estudiantes.Count);
        }
        public void FiltrarAprobados()
        {
            Console.WriteLine("Estudiantes con calificacion mayor o igual a 6.0:");
            foreach (Estudiante estudiante in estudiantes)
            {
                if (estudiante.Calificacion >= 6.0)
                {
                    Console.WriteLine("Nombre:" + estudiante.NombreCompleto + "   Calificacion:" + estudiante.Calificacion);
                }
            }
        }
        public void DarDeBaja()
        {
            string nombreBaja;
            Console.WriteLine("Ingrese el nombre del estudiante que quiera dar de baja");
            nombreBaja = Console.ReadLine();
            estudiantes.RemoveAll(estudiante=>estudiante.NombreCompleto==nombreBaja);
            Console.WriteLine("Se elimino el estudiante si se encontraba presente");
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            GestionAcademica gestionAcademica1 = new GestionAcademica();
            gestionAcademica1.CargarEstudiantes();
            gestionAcademica1.ListarEstudiantes();
            gestionAcademica1.FiltrarAprobados();
            gestionAcademica1.DarDeBaja();
            gestionAcademica1.ListarEstudiantes();
            Console.ReadKey();
        }
    }
}
