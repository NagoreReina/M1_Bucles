using System;

namespace Ejercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que te indique la fecha del día siguiente a la que el 
            //usuario haya introducido por teclado. Habrá que verificar que la fecha introducida es correcta.

            inicio:
            Console.WriteLine("Introduce la fecha que quieras siguiendo este formato dd-mm-AAAA");
            string actualDate = Console.ReadLine();
            //Separar la fecha introducida
            String[] spearator = { "-", "/" };
            Int32 count = 3;
            String[] separatedDateText = actualDate.Split(spearator, count, StringSplitOptions.RemoveEmptyEntries);

            //pasar el texto a numeros
            int[] separatedDate = new int[3];
            for (int i = 0; i < separatedDateText.Length; i++)
            {
                separatedDate[i] = Convert.ToInt32(separatedDateText[i]);
            }

            //almacenamos en estas variables para que sea mas facil de entender el codigo
            int year = separatedDate[2];
            int day = separatedDate[0];
            int month = separatedDate[1];

            bool bisiesto = false;


            //Saber si el año es bisiesto o no 
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        //SI
                        bisiesto = true;
                    }
                    else
                    {
                        //NO
                        bisiesto = false;
                    }

                }
                else
                {
                    //SI
                    bisiesto = true;
                }
            }
            else
            {
                //NO
                bisiesto = false;
            }

            //Comprobar que la fecha es correcta
            if (month <= 12 || day <= 31)
            {
                if (!bisiesto)
                {
                    if (month == 02 && day <= 28) //primero miramos a ver si es febrero
                    {
                        //FECHA CORRECTA --------------------------------
                        if (day < 28)
                        {
                            Console.WriteLine($"El dia siguiente es {day+1}-{month}-{year}");
                        }
                        else
                        {
                            Console.WriteLine($"El dia siguiente es 1-{month+1}-{year}");
                        }
                    }
                    else if (month == 2 && day > 28)
                    {
                        //FECHA INCORRECTA
                        Console.WriteLine("La fecha no es correcta, intentalo de nuevo");
                        goto inicio;
                    }
                    if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                    {
                        if (day <= 31)
                        {
                            //FECHA CORRECTA --------------------------------
                            if (day < 31)
                            {
                                Console.WriteLine($"El dia siguiente es {day + 1}-{month}-{year}");
                            }
                            else
                            {
                                if (month != 12)
                                {
                                    Console.WriteLine($"El dia siguiente es 1-{month + 1}-{year}");
                                }
                                else
                                {
                                    Console.WriteLine($"El dia siguiente es 1-1-{year+1}");
                                }
                            }
                        }
                        else
                        {
                            //FECHA INCORRECTA
                            Console.WriteLine("La fecha no es correcta, intentalo de nuevo");
                            goto inicio;
                        }
                    }
                    else
                    {
                        if (day <= 30)
                        {
                            //FECHA CORRECTA --------------------------------
                            if (day < 30)
                            {
                                Console.WriteLine($"El dia siguiente es {day + 1}-{month}-{year}");
                            }
                            else
                            {  
                                Console.WriteLine($"El dia siguiente es 1-{month + 1}-{year}");
                            }
                        }
                        else
                        {
                            //FECHA INCORRECTA
                            Console.WriteLine("La fecha no es correcta, intentalo de nuevo");
                            goto inicio;
                        }
                    }

                }
                else if (month == 2)
                {
                    if ( day <= 29) //primero miramos a ver si es febrero
                    {
                        //FECHA CORRECTA --------------------------------
                        if (day < 29)
                        {
                            Console.WriteLine($"El dia siguiente es {day + 1}-{month}-{year}");
                        }
                        else
                        {
                            Console.WriteLine($"El dia siguiente es 1-{month + 1}-{year}");
                        }
                    }
                    else
                    {
                        //FECHA INCORRECTA
                        Console.WriteLine("La fecha no es correcta, intentalo de nuevo");
                        goto inicio;
                    }
                }
            }
            else
            {
                //FECHA INCORRECTA
                Console.WriteLine("La fecha no es correcta, intentalo de nuevo");
                goto inicio;
            }
            goto inicio;
            
        }
    }
}
