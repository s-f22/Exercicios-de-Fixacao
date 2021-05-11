using System;

namespace VETORES___06
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[10];
            string busca;
            int contador = 0;

            for (var i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine($"Insira o {i + 1}º nome: ");
                nomes[i] = Console.ReadLine().ToUpper();
            }

            Console.WriteLine("Qual nome deseja buscar? ");
            busca = Console.ReadLine().ToUpper();

            for (var j = 0; j < nomes.Length; j++)
            {
                if (nomes[j] == busca)
                {
                    contador++;
                }
            }

            if (contador > 0)
            {
                Console.WriteLine($"ACHEI! O nome {busca} foi encontrado {contador} vez(es).");
            }
            else
            {
                Console.WriteLine($"NÃO ACHEI o nome {busca}.");
            }
        }
    }
}
