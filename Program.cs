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

            //definimos las variables
            int n, mayor=0, conImpares=0, menor=0;
            bool banderaMayor=true, banderaMenor=true;

            //pedimos un numero
            Console.WriteLine("Por favor, ingrese un número o 0 para salir :");
            n = int.Parse(Console.ReadLine());
            
            //inicializamos un ciclo inexacto while que cortara cuando se ingrese por pantalla un 0
            while (n != 0)
            {   
                //Realizamos el apartado A) el mayor de los numeros pares                
                if (par(n))
                {     
                    bandera(n, ref banderaMayor, ref mayor);                 
                    mayorNum(n, ref mayor);                  
                }

                //Realizamos el apartado B) La cantidad de números impares.
                else
                {                
                    conImpares++;
                }
                
                //Realizamos el apartado C)El menor de los números primos.                
                if (primo(n))
                {
                    bandera(n, ref banderaMenor, ref menor);
                    menorNum(n, ref menor); 
                }
                Console.WriteLine("Por favor, ingrese un número o 0 para salir :");
                n = int.Parse(Console.ReadLine());                
            }

            Console.WriteLine("El mayor de los numeros pares es: " + mayor);
            Console.WriteLine("El total de números impares es: " + conImpares);
            Console.WriteLine("El menor de los numeros primos es: " + menor);
        }

        //función que devuelve verdadero si el numero ingresado es primo.
        static bool primo(int a)
        {   int con = 0;
            for (int x = 0; x < a; x++)
            {   
                if (a % (x+1) == 0)
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
            if (a % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //funcion que devuelve el mayor entre dos numeros
        static int mayorNum(int valorEvaluar, ref int mayor)
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
        //funcion que devuelve el menor entre dos numeros
        static int menorNum(int valorEvaluar, ref int menor)
        {
            if (menor >= valorEvaluar)
            {
                menor = valorEvaluar;
                return menor;
            }
            else
            {
                return menor;
            } 
        }

        // funcion tal que si ingreso un booleano con la asignacion verdadera, esta almacenara en la variable "mayor" el valor que contenga la variable "n".
        //esta funcion siempre retornara la variable bandera con falso.
        static bool bandera(int n, ref bool bandera,ref int mayor )
        {   
            if (bandera)
            {
                mayor=n;
                bandera=false;
                return bandera;
            }
            else
            {
                return bandera;
            }
        }
        
        
    }
}
