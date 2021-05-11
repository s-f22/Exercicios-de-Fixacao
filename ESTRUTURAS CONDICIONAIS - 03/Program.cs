using System;

namespace ESTRUTURAS_CONDICIONAIS___03
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome_prod;
            int qtde;
            double preco_unit, total, desconto;
            int val_desconto;

            Console.WriteLine("Insira o nome do produto: ");
            nome_prod = Console.ReadLine().ToUpper();

            Console.WriteLine("Insira a quantidade: ");
            qtde = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira a preço unitário: ");
            preco_unit = float.Parse(Console.ReadLine());

            
            if (qtde <= 5)
            {
                desconto = 0.98;
                total = (preco_unit * qtde) * desconto;
                val_desconto = 2;
            }
            else if (qtde > 5 && qtde <= 10)
            {
                desconto = 0.97;
                total = (preco_unit * qtde) * desconto;
                val_desconto = 3;
            }
            else
            {
                desconto = 0.95;
                total = (preco_unit * qtde) * desconto;
                val_desconto = 5;
            }

            Console.WriteLine($"Produto: {nome_prod}");
            Console.WriteLine($"Total: R${Math.Round((preco_unit * qtde), 2)}");
            Console.WriteLine($"Desconto: {val_desconto}%");
            Console.WriteLine($"Total a pagar: {Math.Round(total, 2)}");
        }

            
    }
}

