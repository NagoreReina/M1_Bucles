using System;

namespace EjercicioLargo
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            do
            {
                Console.WriteLine("\t *************** \n  \t   Calculadora \n \t *************** \n \t(escoge una opción) \n \t 1. Suma \n \t 2. Resta \n \t 3. Multiplicar \n \t 4. Potencia \n \t 5. División \n \t 6. Raiz \n \t 7. Salir");
                option = Convert.ToInt32(Console.ReadLine());
                double num1 = 0;
                double num2 = 0;
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Introduce el primer valor");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Introduce el segundo valor");
                        num2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Operación seleccionada: Suma");
                        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                        break;
                    case 2:
                        Console.WriteLine("Introduce el primer valor");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Introduce el segundo valor");
                        num2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Operación seleccionada: Resta");
                        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                        break;
                    case 3:
                        Console.WriteLine("Introduce el primer valor");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Introduce el segundo valor");
                        num2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Operación seleccionada: Multiplicación");
                        Console.WriteLine($"{num1} x {num2} = {num1 * num2}");
                        break;
                    case 4:
                        Console.WriteLine("Introduce el primer valor");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Introduce el segundo valor");
                        num2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Operación seleccionada: Potencia");
                        Console.WriteLine($"{num1} ^ {num2} = {Math.Pow(num1, num2)}");
                        break;
                    case 5:
                        Console.WriteLine("Introduce el primer valor");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Introduce el segundo valor");
                        num2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Operación seleccionada: División");
                        Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                        break;
                    case 6:
                        Console.WriteLine("Introduce el valor");
                        num1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Operación seleccionada: Raiz");
                        Console.WriteLine($"Raiz cuadrada de {num1}  = {Math.Sqrt(num1)}");
                        break;
                    case 7:
                        Console.WriteLine("Programa cerrado");
                        break;
                    default:
                        Console.WriteLine($"opción {option} no disponible, vuelva a intentarlo");
                        break;
                }
            } while (option != 7);
            
        }
    }
}
