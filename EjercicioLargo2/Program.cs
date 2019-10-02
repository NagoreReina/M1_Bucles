using System;
using System.Linq;

namespace EjercicioLargo2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            string selected = "";
            double m = 0; //Memoria
            bool hasMemory = false; //saber si se ha hecho una operacion antes
            bool uError = false;
            do
            {
                Console.WriteLine("Introduce tu operación (opciones: +, /, -, *, ^, r) e es para elevar y r para raiz");
                string operation = Console.ReadLine();
                operation = operation.ToLower();
                selected = operation;
                uError = false;

                if (selected != "q") //si fuese q, saldria del programa
                {
                    String[] spearator = { "+", "/", "-", "*", "^", "r" }; 
                    String[] separatedOperation = operation.Split(spearator, StringSplitOptions.RemoveEmptyEntries);

                    if (separatedOperation.Length > 2) //por si introducen operaciones de mas de 2 valores
                    {
                        Console.WriteLine("La operación introducida no es correcta, prueba otra vez (máximo de 2 valores)");
                        uError = true;
                    }
                    else
                    {
                        bool negative1 = false;
                        bool negative2 = false;
                        int numOfNegatives = 0;
                        if (operation.IndexOf("-") != -1)
                        {
                            numOfNegatives = operation.Count(x => x == '-');
                            if (numOfNegatives <= 1)
                            {
                                if (operation.IndexOf("-") == 0)
                                {
                                    negative1 = true;
                                }
                                else
                                {
                                    negative2 = true;
                                }
                            }
                            else
                            {
                                negative1 = true;
                                negative2 = true;
                            }
                        }
                        

                        if (operation.IndexOf("m") != -1) //mirar si el usuario quiere operar con memoria
                        {
                            if (hasMemory) //mirar si existe memoria
                            {
                                if (operation.Contains("r")) 
                                {
                                    num1 = m;
                                }
                                else
                                {
                                    if (operation.IndexOf("m") == 0) //mirar en que valor se quiere usar la memoria y asignar
                                    {
                                        num1 = m;
                                        num2 = Convert.ToDouble(separatedOperation[1]);
                                        if (negative2)
                                        {
                                            num2 *= -1;
                                        }

                                    }
                                    else
                                    {
                                        num2 = m;
                                        num1 = Convert.ToDouble(separatedOperation[0]);
                                        if (negative1)
                                        {
                                            num1 *= -1;
                                        }

                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("No hay memoria, intentalo otra vez");
                                uError = true;
                            }
                        }
                        else
                        {
                            // si no se ha introducido memoria, asignar valores
                            num1 = Convert.ToDouble(separatedOperation[0]);
                            if (negative1)
                            {
                                num1 *= -1;
                            }
                            if (!operation.Contains("r"))
                            {
                                num2 = Convert.ToDouble(separatedOperation[1]);
                                if (negative2)
                                {
                                    num2 *= -1;
                                }
                            }
                        }

                        //operaciones
                        if (!uError)
                        {
                            if (operation.Contains("+"))
                            {
                                Console.WriteLine("Operación seleccionada: Suma");
                                Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                                m = num1 + num2;
                                hasMemory = true;
                            }
                            else if (operation.Contains("-"))
                            {
                                Console.WriteLine("Operación seleccionada: Resta");
                                Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                                m = num1 - num2;
                                hasMemory = true;
                            }
                            else if (operation.Contains("*"))
                            {
                                Console.WriteLine("Operación seleccionada: Multiplicación");
                                Console.WriteLine($"{num1} x {num2} = {num1 * num2}");
                                m = num1 * num2;
                                hasMemory = true;
                            }
                            else if (operation.Contains("^"))
                            {
                                Console.WriteLine("Operación seleccionada: Potencia");
                                Console.WriteLine($"{num1} ^ {num2} = {Math.Pow(num1, num2)}");
                                m = Math.Pow(num1, num2);
                                hasMemory = true;
                            }
                            else if (operation.Contains("/"))
                            {
                                Console.WriteLine("Operación seleccionada: División");
                                Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                                m = num1 / num2;
                                hasMemory = true;
                            }
                            else if (operation.Contains("r"))
                            {
                                Console.WriteLine("Operación seleccionada: Raiz");
                                Console.WriteLine($"Raiz cuadrada de {num1}  = {Math.Sqrt(num1)}");
                                m = Math.Sqrt(num1);
                                hasMemory = true;
                            }
                        }
                        
                    }
                }
            } while (selected != "q");

        }
    }
}
