using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    /*
 1-
 En un servidor de red, las solicitudes de impresión se procesan dinámicamente en orden de
llegada.
 Crear la clase Documento que contenga como atributos privados:
nombreArchivo (string) y cantidadPaginas (int). Definir sus
propiedades de solo lectura y un constructor que reciba los parámetros nom
y pag.
 Crear la clase ServidorImpresion que administre una lista dinámica de
documentos (List&lt;Documento&gt;).
 Métodos en ServidorImpresion:
1. AgregarDocumento(): Solicitar por teclado los datos de un
documento y agregarlo al final de la lista utilizando .Add().
2. ImprimirSiguiente(): Si la lista no está vacía, simular la
impresión del primer documento de la lista (mostrar sus datos en
consola) y removerlo de la colección mediante .RemoveAt(0). Si está
vacía, advertir que no hay trabajos pendientes.
3. MostrarColaPendiente(): Listar todos los documentos que
están esperando ser impresos y la cantidad total de páginas
acumuladas en la cola de espera utilizando .Count.*/
    class Documento
    {
        private string nombreArchivo;
        private int cantidadPaginas;

        public Documento(string nom, int pag)
        {
            nombreArchivo = nom;
            cantidadPaginas = pag;
        }
        public string NombreArchivo
        {
            get { return nombreArchivo; }
            set { nombreArchivo = value; }
        }
        public int CantidadPaginas
        {
            get { return cantidadPaginas; }
            set { cantidadPaginas = value; }
        }
    }
        class ServidorImpresion
    {
        List<Documento> documentos = new List<Documento>();
        public void AgregarDocumento()
        {
            Console.WriteLine("Ingrese el nombre del nuevo documento");
            string nom = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad de paginas del nuevo documento");
            int pag = int.Parse(Console.ReadLine());
            documentos.Add(new Documento(nom,pag));
        }
        public void ImprimirSiguiente()
        {
            if (documentos.Count > 0)
            {
                    Console.WriteLine("Nombre Documento:"+documentos[0].NombreArchivo+" Paginas:" + documentos[0].CantidadPaginas);
                documentos.RemoveAt(0);
                    if (documentos.Count == 0)
                    {
                        Console.WriteLine("No hay trabajos pendientes");
                    }
            }
        }
        public void MosrarColaPendiente()
        {
            if (documentos.Count == 0)
            {
                Console.WriteLine("No hay documentos que listar");
            }
            else
            {
                int totalDocumentos, totalPaginas;
                totalPaginas = 0;
                totalDocumentos = documentos.Count;
                Console.WriteLine("Listado de Documentos:");
                foreach (Documento documento in documentos)
                {
                    Console.WriteLine(documento.NombreArchivo);
                    totalPaginas += documento.CantidadPaginas;
                }
                Console.WriteLine("Documentos totales:" + totalDocumentos);
                Console.WriteLine("Paginas totales acumuladas:" + totalPaginas);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ServidorImpresion servidor1 = new ServidorImpresion();
            servidor1.AgregarDocumento();
            servidor1.AgregarDocumento();
            servidor1.AgregarDocumento();
            servidor1.ImprimirSiguiente();
            servidor1.MosrarColaPendiente();
            Console.ReadKey();
        }
    }
}
