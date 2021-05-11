using System;

namespace ESTRUTURAS_CONDICIONAIS___01
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano_atual = DateTime.Now.Year;
            
            Console.WriteLine("Em que ano você nasceu?");
            int ano_nascimento = int.Parse(Console.ReadLine());

            int idade = ano_atual - ano_nascimento;

            if (idade >= 16 && idade < 18)
            {
                Console.WriteLine($"Você tem {idade} anos e já pode votar.");
            }
            else if (idade >= 18)
            {
                Console.WriteLine($"Você tem {idade} anos e deve votar.");
            }
            else
            {
                Console.WriteLine($"Você tem {idade} anos e ainda não pode votar.");
            }

        }
    }
}
