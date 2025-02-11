using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Un supermercado necesita un programa en donde almacenar sus ingresos,
            los cuales son la sumatoria de todas las ventas realizadas a los clientes
            (100 clientes).
            */

            float suma = 0;

            Random ventas = new Random();

            float[] clientes = new float[101];

            for (int i = 1; i < clientes.Length; i++)
            {
                clientes[i] = ventas.Next(100,1001);
                suma += clientes[i];
                Console.WriteLine("El Cliente " + i + " gasto: " + clientes[i]); 
            }

            Console.WriteLine("Los ingresos del supermercado son: $" + suma); 
        }
    }
}
