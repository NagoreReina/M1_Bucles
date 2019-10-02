using System;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Un número factorial es el resultado de multiplicar todos 
            //los números de 1 a ese mismo número (por ejemplo el factorial de 4 es 1 x 2 x 3 x 4 = 24). 
            //Haz un programa que muestre los números del 1 al 10 en una columna con el resultado de su 
            //factorial en la columna de al lado.

            Console.WriteLine("Factoriales");
            int num = 1;
            int fact = 1;
            int cont = num; ;

            while (num < 10)
            {
                if (cont <= num)
                {
                    fact *= cont;
                    cont++;
                }
                else
                {
                    Console.WriteLine($"{num}   {fact}");
                    num++;
                    cont = num;
                }
                
            }
        }
    }
}
