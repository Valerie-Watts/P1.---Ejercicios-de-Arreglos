using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Se necesita un programa que capture 20 numeros en tres diferentes arreglos,
            en el primero se almacena el numero tal cual se tecleo, en el segundo se almacena
            el cuadrado de dicho numero y en el tercero su cubo. 
             */

            Random random = new Random(); 

            float[] number = new float[21];
            float[] square = new float[21];
            float[] cubic = new float[21];

            Console.WriteLine("Number Imputed: Number Squared: Number Cubed:");

            for (int i = 1; i < number.Length ; i++)
            {
               number[i] = random.Next(1,21);
               square[i] = number[i] * number[i];
               cubic[i] = number[i] * number[i] * number[i];

                Console.WriteLine(number[i] + "\t" + "\t" + square[i] + "\t" + "\t" + cubic[i]);
            }

            

           

        }


    }
}
