using System;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que muestre el resultado de sumar todos los números del 1 
            //hasta el número introducido y que vuelva a pedirle al usuario otro número hasta 
            //que el usuario introduzca un 0
            int num = 1;
            while (num != 0)
            {
                Console.WriteLine("Introduce un numero");
                num = Convert.ToInt32(Console.ReadLine());
                int sum = 0;
                for (int i = 1; i < num + 1; i++)
                {
                    sum += i;
                }
                Console.WriteLine(sum);
                Console.WriteLine("-----------------------------------");
            }
            
        }
    }
}
