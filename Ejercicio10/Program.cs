using System;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un programa que muestre el valor de sumar todos los números desde 1 
            //hasta el número que introduzca el usuario. Por ejemplo si introduce el 8 
            //debería mostrar 36 (1 + 2+ 3+ 4+ 5+ 6+ 7+ 8)

            inicio:
            Console.WriteLine("Introduce un numero");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i < num +1; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
            Console.WriteLine("-----------------------------------");
            goto inicio;
        }
    }
}
