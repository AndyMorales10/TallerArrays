using System;

namespace Ejercicio33
{
    //Realizar un algoritmo que declare 3 arrays de 5 elementos cada uno. Llenar el vector1 y vector2 y calcular vector3 = vector1 + vector2.
    public class Ejercicio33
    {
        static void Main(string[] args)
        {
            int[] vector1 = new int[5];
            int[] vector2 = new int[5];
            int[] vector3 = new int[5];

            Console.WriteLine("Ingrese los elementos del vector1: ");
            Console.WriteLine("");

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese el elemento {0}: ", i + 1);
                vector1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nIngrese los elementos del vector2: ");
            Console.WriteLine("");

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese el elemento {0}: ", i + 1);
                vector2[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                vector3[i] = vector1[i] + vector2[i];
            }

            Console.WriteLine("\nEl resultado de la suma de vector1 y vector2 (vector3) es: ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(vector3[i]);
            }

            Console.ReadLine();
        }
    }
}
