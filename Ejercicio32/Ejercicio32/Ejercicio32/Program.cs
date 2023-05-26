using System;

namespace Ejercicio32
{
    public class Ejercicio32
    {
        //Pedir N números por pantalla y guardarlos en vector. Mostrar el número máximo y el número mínimo.
        static void Main(string[] args)
        {
            int n,max,min;

            Console.WriteLine("Ingrese la cantidad de números para el Array: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] numeros = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Ingrese el número {0}: ", i + 1);
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
            }

            max = numeros[0];
            min = numeros[0];

            for (int i = 1; i < n; i++)
            {
                if (numeros[i] > max)
                    max = numeros[i];

                if (numeros[i] < min)
                    min = numeros[i];
            }

            Console.WriteLine("El número máximo es: " + max);
            Console.WriteLine("El número mínimo es: " + min);

            Console.ReadLine();


        }
    }
}
