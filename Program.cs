using System;

namespace TPFinal_Sanchez
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. A partir de dichos datos informar:
                //a. El mayor de los números pares.
                //b. La cantidad de números impares.
                //c. El menor de los números primos.

                //Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva true o false según corresponda.    
            int n, mayor;
            Console.WriteLine("Por favor, ingrese un número o 0 para salir :");
            n = int.Parse(Console.ReadLine());
            //mayor = n;
            while (n != 0)
            {   //el mayor de los numeros pares
                Console.WriteLine("Por favor, ingrese un número o 0 para salir :");
                n = int.Parse(Console.ReadLine());

                
            }
                
        }
        //función que devuelve verdadero si el numero ingresado es primo.
        static bool primo(int a)
        {   int con = 0;
            for (int x = 0; x < a; x++)
            {   con = 0;
                if (a / (x+1) == 0)
                {
                    con++;
                }                
            }
            if (con == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
        }
        //Función que devuelve verdadero si el numero es par.
        static bool par(int a)
        {
            if (a / 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //funcion que devuelve el mayor entre dos numeros
        static int mayor(int mayor, int valorEvaluar)
        {
            if (mayor <= valorEvaluar)
            {
                mayor = valorEvaluar;
                return mayor;
            }
            else
            {
                return mayor;
            } 
        }
        
    }
}
