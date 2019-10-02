using System;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mostrar en pantalla diez números, siendo el primero 1 y los siguientes la suma del número anterior.
            int n = 1;
            Console.WriteLine(n);
            for (int i = 1; i < 10; i++)
            {
                n += n;
                Console.WriteLine(n);
            }
        }
    }
}
