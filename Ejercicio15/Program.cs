using System;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que pida un número y muestre el resultado de sumar sus dígitos.
            inicio:
            Console.WriteLine("Introduce un numero");
            string num = Console.ReadLine();
            char[] allNums = num.ToCharArray();
            if (allNums.Length == 1)
            {
                Console.WriteLine($"la suma de sus digitos es {num}");
            }
            else
            {
                int n = 0;
                for (int i = 0; i < num.Length; i++)
                {
                    n += Convert.ToInt32(allNums[i].ToString());
                }
                Console.WriteLine($"la suma de sus digitos es {n}");
            }
            goto inicio;

        }
    }
}
