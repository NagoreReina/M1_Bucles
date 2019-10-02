using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que muestre en pantalla los números del 20 al 10 (incluidos los dos) 
            //con una línea vacía entre ellos.
            for (int i = 21; i > 9; i--)
            {
                Console.WriteLine(i);
                Console.WriteLine("");
            }
        }
    }
}
