using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Se necesita un programa que utilice un arreglo de seis posiciones para 
            almacenar los 5 parciales de un alumno y sacar su promedio, el cual se guardara 
            en la ultima localidad. Mostrando todas las calificaciones y el promedio. 
             */

            float promedio = 0;
            float suma = 0; 
            float[] array = new float[5];

            Console.WriteLine("Inserte las calificaciones del alumno: ");

            for (int i = 0; i < array.Length; i++)
            {
                float grades = Convert.ToInt32(Console.ReadLine());

                array[i] = grades;

                suma += array [i]; 


                promedio = suma / array.Length;
            }

            Console.WriteLine("\nLas calificaciones agregadas: \n"); 

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]); 

            }

            Console.WriteLine("El promedio es: " + promedio);

            Console.ReadKey(); 
        }
    }
}
