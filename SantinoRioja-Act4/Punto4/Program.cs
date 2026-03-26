using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4. En un banco se procesan datos de las cuentas corrientes de sus clientes. De cada
            //cuenta corriente se conoce: número de cuenta y saldo actual. El ingreso de datos debe
            //finalizar al ingresar un valor negativo en el número de cuenta.
            //Se pide confeccionar un programa que lea los datos de las cuentas corrientes e
            //informe:
            //a) De cada cuenta: número de cuenta y estado de la cuenta según su saldo,
            //sabiendo que:
            //Estado de la cuenta:
            //○ “Acreedor” si el saldo es > 0.
            //○ “Deudor” si el saldo es < 0.
            //○ “Nulo” si el saldo es = 0.
            //b) La suma total de los saldos acreedores.
            int num_cuenta;
            int saldo;
            int suma_acreedores = 0;
            string estado_cuenta = "" ;
            string datos = "";
            int i=0;
            while (i==0) {
            Console.WriteLine("Ingrese el numero de cuenta, para finalizar ingrese un numero negativo");
                num_cuenta = int.Parse(Console.ReadLine());
                if (num_cuenta < 0) { i++; break; }
                Console.WriteLine("ingrese saldo");
                saldo = int.Parse(Console.ReadLine());
                if (saldo > 0) { suma_acreedores += saldo;
                estado_cuenta = "acreedor  ";
                }
                if (saldo < 0) { estado_cuenta = "deudor  "; }
                if (saldo==0){ estado_cuenta = "nulo  "; }

                datos += ("Numero de cuenta:" + num_cuenta + " saldo:$" + saldo +" Estado de la cuenta:" + estado_cuenta  );
            }
            Console.WriteLine(datos + "saldo total acreedores:" + suma_acreedores);
            Console.ReadKey();

        } 
        }

    }

