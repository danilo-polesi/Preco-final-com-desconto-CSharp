using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco, precofinal, precofinaltotal, desconto, quantidadeproduto;
            string nomeproduto;

            Console.Write("Digite o nome do produto: ");
            nomeproduto = Convert.ToString(Console.ReadLine());
            Console.Write("Digite o preço do produto: ");
            preco = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a quantidade de produtos: ");
            quantidadeproduto = Convert.ToDouble(Console.ReadLine());
            precofinal = preco * quantidadeproduto;
            Console.Write("Digite a porcentagem do desconto: ");
            desconto = Convert.ToDouble(Console.Read());
            precofinaltotal = Convert.ToDouble(Console.ReadLine());
            precofinaltotal = precofinal - (precofinal * (desconto / 100));

            Console.Write("O preço final total do " + nomeproduto + " será R$" + precofinaltotal + " na quantidade de " + quantidadeproduto + " produtos");
            Console.ReadKey();
        }
    }
}
