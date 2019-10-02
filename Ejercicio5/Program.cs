using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que muestre todos los valores pares o impares entre 1 y 100 
            //dependiendo de si el usuario introduce P o I . Si introduce otra cosa, decir que 
            //ese valor no es correcto y pedirle otra vez.
            string choose = "";

            while(choose != "p" && choose != "i")
            {
                Console.WriteLine("Introduce P si quieres ver los valores Pares o I si quieres ver los valores impares");
                Console.WriteLine("--------------------------------");
                choose = Console.ReadLine().ToLower();
                if (choose != "p" && choose != "i")
                {
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("No es un valor correcto");
                }
            }
            Console.WriteLine("--------------------------------");
            int n = 0;
            if (choose == "p")
            {
                while (n < 100)
                {
                    n += 2;
                    Console.WriteLine(n);
                }
            }
            else
            {
                n = 1;
                while (n < 99)
                {
                    n += 2;
                    Console.WriteLine(n);
                }
            }
            
        }
    }
}
