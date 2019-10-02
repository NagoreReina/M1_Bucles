using System;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Realiza un programa que muestre por pantalla los números del 1 al 100 sin 	
            //mostrar aquellos números múltiplos de 5.

            Console.WriteLine("Numeros de 1 al 100 sin multiplos de 5");
            for (int i = 0; i <= 100; i++)
            {
                if (i%5 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
