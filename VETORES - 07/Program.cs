using System;

namespace VETORES___07
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[15];
            
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Digite um numero inteiro: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nOs numeros digitados foram: ");
            
            for (int j = (numeros.Length - 1); j >= 0; j--)
            {
                Console.Write($"{numeros[j]} ");
            }
        }
    }
}
