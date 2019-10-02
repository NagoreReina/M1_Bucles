using System;

namespace Bucles
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            //Ejercicio 1

            while (num <= 100)
            {
                Console.WriteLine(num);
                num++;
            }

            //Ejercicio 2
            do
            {
                Console.WriteLine("Introduce un numero");
                num = Convert.ToInt32(Console.ReadLine());

            } while (num >= 0);

            //Ejercico 3
            while (num >= 0)
            {
                Console.WriteLine("Introduce un numero");
                num = Convert.ToInt32(Console.ReadLine());

            }
            //Ejercicio 4
            int suma = 0;
            for (int i = 0; i <= 8; i++)
            {
                Console.WriteLine("Introduce un numero");
                num = Convert.ToInt32(Console.ReadLine());
                suma += num;
            }
            Console.WriteLine(suma);
        }
    }
}
