using System;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que muestre el número entero positivo que el usuario introduzca pero al revés 
            //(si introduce 1478 que muestre 8741), hasta que el usuario introduzca 0. Si introduce 0 la primera vez,
            //debería mostrarlo al revés (es decir, mostrar 0) y acabar el programa.
            int n = 1;
            while (n!= 0)
            {
                Console.WriteLine("Introduce un numero");
                string num = Console.ReadLine();
                char[] allNums = num.ToCharArray();
                //asi comprobamos si ha introducido un 0
                if (allNums.Length == 1)
                {
                    n = Convert.ToInt32(allNums[0].ToString()); 
                    
                }
                string text = "";
                int i = num.Length;
                while(i != 0)
                {
                    text += allNums[i-1];
                    i--;
                }
                Console.WriteLine(text);

            }

        }
    }
}
