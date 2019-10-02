using System;
using System.Linq;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa el cual analizará si la contraseña introducida es correcta o no. 
            //Para que la contraseña sea correcta deberá cumplir estas directivas:
            //- Debe tener 8 caracteres como mínimo.
            //- La contraseña deberá contener números. (buscar una función)
            //- La primera letra tiene que ser en mayúsculas.(buscar una función)
            Console.WriteLine("Introduce una contraseña");
            string password = Console.ReadLine();
            if (password.Any(char.IsDigit) && char.IsUpper(password[0]) && password.Length >= 8)
            {
                Console.WriteLine("La contraseña es correcta");
            }
            else
            {
                Console.WriteLine("La contraseña no cumple los requisitos: ");
                Console.WriteLine("- Debe tener 8 caracteres como mínimo.");
                Console.WriteLine("- La contraseña deberá contener números.");
                Console.WriteLine("- La primera letra tiene que ser en mayúsculas.");
            }

        }
    }
}
