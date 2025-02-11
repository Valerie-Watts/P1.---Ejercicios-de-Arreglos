using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Necesitamos un programa que capture 20 numeros y despues de capturarlos que haga
             revision de estos para indicarnos cuantos son pares y cuantos son impares
             */

            Console.WriteLine("Odd or even indicator"); 

            float par = 0;
            float impar = 0; 

            Random numbers = new Random();

            int[] pairOrImpar = new int[21];

            for (int i = 1; i < pairOrImpar.Length; i++)
            {
                pairOrImpar[i] = numbers.Next(1,100);

                Console.WriteLine("Number " + i + " = " + pairOrImpar[i]);

                if (pairOrImpar[i] % 2 != 0)
                {
                    impar += 1;
                }
                else {
                    par += 1; 
                }
            }

            Console.WriteLine("There are " + par + " even numbers.");
            Console.WriteLine("There are " + impar + " odd numbers.");
        }
    }
}
