using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Se necesita un programa que utiliza 3 arreglos, en los dos primeros se colocan los 
            promedios de dos grupos de 5 alumnos cada uno y el tercer arreglo almacena el promedio
            mas alto de cada posicion. Imprimir los promedios mas altos. */

            int[] grupo1 = new int[5];
            int[] grupo2 = new int[5];
            int[] promAlto = new int[5];

            Random grades = new Random(); 

            for (int i = 0; i < grupo1.Length; i++)
            {
                grupo1[i] = grades.Next(1,11); 

            }

            for (int j = 0; j < grupo2.Length; j++)
            {
                grupo2[j] = grades.Next(1, 11);

            }


            for (int k = 0; k < promAlto.Length; k++)
            {
                if (grupo1[k] > grupo2[k])
                {

                    promAlto[k] = grupo1[k];
                   
                }
                else
                {

                    promAlto[k] = grupo2[k];
                    
                }

            }
            Console.WriteLine("Promedios de cada grupo: ");
            Console.WriteLine("Grupo 1: " + string.Join(",",grupo1));
            Console.WriteLine("Grupo 2: " + string.Join(",", grupo2));

            Console.WriteLine("Los promedios mas altos en cada posicion son: ");
            Console.WriteLine(string.Join(",",promAlto));
        }
    }
}
