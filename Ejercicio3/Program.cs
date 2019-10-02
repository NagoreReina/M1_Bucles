using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que pida 10 valores. Al final mostrar la media de esos valores.
            double value = 0;
            double suma = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"introduce el valor nº {i+1}");
                value = Convert.ToDouble(Console.ReadLine());
                suma += value;
            }
            Console.WriteLine($"la media de los valores introducidos es: {(suma/10).ToString("0.00")}");
        }
    }
}
