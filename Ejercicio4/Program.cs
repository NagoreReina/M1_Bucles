using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que pida valores hasta que el usuario introduzca un 0. 
            //Si introduce un valor negativo, mostrar un mensaje diciendo que se ignoran 
            //los valores negativos. Mostrar la suma de los valores introducidos. 
            double n = 1;
            double suma = 0;
            while (n != 0)
            {
                Console.WriteLine("Introduce un valor");
                n = Convert.ToDouble(Console.ReadLine());
                if (n < 0)
                {
                    Console.WriteLine("Los valores negativos se ignorarán");
                }
                else
                {
                    suma += n;
                }
            }
            Console.WriteLine($"la suma de todos los valores es {suma}");
        }
    }
}
