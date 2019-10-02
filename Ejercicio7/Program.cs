using System;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            inicio:
            //Pedir al usuario un número. Mostrar en pantalla el dibujo de abajo con tantas líneas 
            //como las que haya introducido:
            //*
            //**
            //***
            Console.WriteLine("Introduce un numero");
            int num = Convert.ToInt32(Console.ReadLine());
            string text = "";
            for (int i = 0; i < num; i++)
            {
                text += "*";
                Console.WriteLine(text);
            }
            Console.WriteLine("- - - - - - - - - - - - - - - -");
            goto inicio;
        }
    }
}
