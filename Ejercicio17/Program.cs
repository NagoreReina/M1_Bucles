using System;

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Se desea conocer el lucky umber (número de la suerte) de cualquier persona. 
             * El número de la suerte se consigue reduciendo la fecha de nacimiento a un número de un 	
             * solo dígito. Por ejemplo, la fecha de nacimiento de Emma es la siguiente: 16-08-1973 	
             * 16+8+1973=1997 	1+9+9+7=26 	2+6=8. El número de la suerte de Emma será el 8.
            */
            inicio:
            Console.WriteLine("Introduce tu fecha de nacimiento con digitos siguiendo este formato dd-mm-AAAA");
            string birthDate = Console.ReadLine();
            //Separar la fecha introducida
            String[] spearator = { "-", "/"};
            Int32 count = 3;
            String[] strlist = birthDate.Split(spearator, count,StringSplitOptions.RemoveEmptyEntries);

            //pasar el texto a numeros
            int[] totalNums = new int[3];
            for (int i = 0; i < strlist.Length; i++)
            {
                totalNums[i] = Convert.ToInt32(strlist[i]);
            }
            int d1 = totalNums[0] / 10;
            int d2 = totalNums[0] % 10;
            int m1 = totalNums[1] % 10;
            int m2 = totalNums[1] / 10;
            int y1 = totalNums[2] / 1000;
            int y2 = totalNums[2] / 100;
            y2 = y2 % 10;
            int y3 = totalNums[2] / 10;
            y3 = y3 % 10;
            int y4 = totalNums[2] % 10;
            int suma = d1 + d2 + m1 + m2 + y1 + y2 + y3 + y4;
            if (suma > 10)
            {
                d1 = suma / 10;
                d2 = suma % 10;
                suma = d1 + d2;
            }
            Console.WriteLine($"tu numero de la suerte es {suma}");
            goto inicio;

            
        }
    }
}
