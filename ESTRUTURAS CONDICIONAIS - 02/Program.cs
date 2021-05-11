using System;

namespace ESTRUTURAS_CONDICIONAIS___02
{
    class Program
    {
        static void Main(string[] args)
        {
            double qtde_cbtvl, valor_A, valor_G;
            bool teste;
            double preco_A = 4.9;
            double preco_G = 5.3;

            Console.WriteLine("Qual a quantidade de combustível? (em litros)");
            qtde_cbtvl = float.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Selecione o combustivel: (A)lcool ou (G)asolina: ");
                string cbtvl = Console.ReadLine().ToLower();

                switch (cbtvl)
                {
                    case "a":
                        if (qtde_cbtvl > 20)
                        {
                            valor_A = (qtde_cbtvl * preco_A) * 0.95;
                        }
                        else
                        {
                            valor_A = (qtde_cbtvl * preco_A) * 0.97;
                        }

                        Console.WriteLine($"Valor a pagar: R${Math.Round(valor_A, 2)}");

                        teste = true;
                        break;

                    case "g":
                        if (qtde_cbtvl > 20)
                        {
                            valor_G = (qtde_cbtvl * preco_G) * 0.94;
                        }
                        else
                        {
                            valor_G = (qtde_cbtvl * preco_G) * 0.96;
                        }

                        Console.WriteLine($"Valor a pagar: R${Math.Round(valor_G, 2)}");

                        teste = true;
                        break;

                    default:
                        Console.WriteLine("Opção Inválida. Tente novamente.");
                        teste = false;
                        break;
                }

            } while (teste == false);



        }
    }
}
