using System;
using System.Linq;

namespace ESTRUTURAS_DE_REPETICAO___04
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numeros = new int [10];
            
            for (var i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Insira um numero inteiro: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

        //int maiorValor = numeros.Max(); maximo valor atribuindo variavel
        //int menorValor = numeros.Min(); minimo valor atribuindo variavel

        //Array.Sort(numeros);
        //Console.WriteLine($"O menor numero é {numeros[0]}");
        //Console.WriteLine($"O maior numero é {numeros[(numeros.Length - 1)]}");

        Console.WriteLine($"O maior valor digitado foi: {numeros.Max()}");
        Console.WriteLine($"O menor valor digitado foi: {numeros.Min()}");
        }
    }
}
