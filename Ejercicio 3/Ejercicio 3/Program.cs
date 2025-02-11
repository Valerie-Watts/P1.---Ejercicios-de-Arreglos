using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Se necesita de un programa que utiliza un arreglo de 5 renglones y cuatro columnas 
             para almacenar los 3 parciales y su promedio de 5 alumnos*/
            Random grades = new Random(); 

            int[,] promedios = new int[5,3];

            Console.WriteLine("Primer parcial: Segundo parcial: Tercer parcial: ");

            for (int i = 0; i < promedios.GetLength(0); i++)
            {
                for (int j = 0; j < promedios.GetLength(1); j++)
                {
                    promedios[i, j] = grades.Next(1,11);
                    Console.Write(promedios[i, j] + "\t	");
                }
                Console.WriteLine(); 
            }
        }
    }
}
