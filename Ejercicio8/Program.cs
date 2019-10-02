using System;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que muestre los números de 1 a 12 en una columna. 
            /*
             1  1
             2  4
             3  9
             4
             5
             6
             7
             8
             9
             10
             11
             12
             */
            //En la columna de al lado de los números impares mostrar el cuadrado de ese valor 
            //y en la de los pares mostrar el cubo.

            int valueToElevate;
            for (int i = 1; i < 13; i++)
            {
                if (i % 2 == 0)
                {
                    valueToElevate = 2;
                }
                else
                {
                    valueToElevate = 3;
                }

                Console.WriteLine($"{i} /t {Math.Pow(i,valueToElevate)}");
            }
        }
    }
}
