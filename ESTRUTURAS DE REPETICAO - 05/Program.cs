using System;

namespace ESTRUTURAS_DE_REPETICAO___05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nTabuadas entre 1 e 10.\n");

            for (var i = 1; i <= 10; i++)
            {
                for (var j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
