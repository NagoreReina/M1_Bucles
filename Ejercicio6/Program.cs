using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que pregunte al usuario su edad. 
            //Mostrar en pantalla “Feliz cumpleaños” repetido tantas veces como años tenga.

            Console.WriteLine("¿Que edad tienes?");
            int age = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < age; i++)
            {
                Console.WriteLine("Feliz cumpleaños");
            }
        }

    }
}
