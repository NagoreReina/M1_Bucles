using System;

namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Mostrar en pantalla una pirámide hecha con un símbolo. 
             * El usuario introduce el símbolo que se usa y un valor que indica la altura 
             * en líneas de la pirámide. Por ejemplo si el usuario introduce # y 7 el resultado será: (DIFICIL)
                #
               ###
              #####
             #######
	        #########
	       ###########
	      #############
*/
            Console.WriteLine("Introduce un numero");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce un caracter");
            string a = Console.ReadLine();
            string text = "";
            int cuantasA = 1;
            int totalDeAs = cuantasA;
            int cont = num;
            while (num != 0)
            {
                if (num > 1)
                {
                    text += " ";
                    num--;
                }
                else
                {
                    while (cuantasA != 0)
                    {
                        text += a;
                        cuantasA--;
                    }
                    totalDeAs += 2;
                    cuantasA = totalDeAs;
                    cont--;
                    num = cont;
                    Console.WriteLine(text);
                    text = "";
                }
            }
        }
    }
}
