using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Se necesita un programa que utiliza una matriz de 10 renglones y 3 columnas.
             En las dos primeras columnas se colocan los promedios de los 10 alumnos de dos grupos 
            A y B, y en la tercera columna se almacenara el promedio mas alto de cada posicion.*/

            float suma = 0; 

            float[,] promedios = new float [10,3];
            
            Random average = new Random();

            Console.WriteLine("Grupo A: Grupo B: Promedio mas alto: "); 


            //Agregar promedios random a columnas 

            for (int i = 0; i < promedios.GetLength(0); i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    promedios[i, j] = average.Next(1,11);
                    Console.Write(promedios[i,j] + "\t");
                }

                if (promedios[i, 0] > promedios[i, 1])
                {

                    promedios[i, 2] = promedios[i, 0];
                }
                else {
                    promedios[i, 2] = promedios[i, 1];
                }

                Console.WriteLine(promedios[i,2]);
            }

       


            Console.ReadKey(); 


        }
    }
}
