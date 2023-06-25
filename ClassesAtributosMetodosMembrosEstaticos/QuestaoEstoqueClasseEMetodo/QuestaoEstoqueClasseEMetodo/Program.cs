using System;
using System.Globalization;
using System.Xml;

namespace QuestaoEstoqueClasseEMetodo {
    internal class Program {
        static void Main(string[] args) {
            Produto p = new Produto();
            Console.WriteLine("Entre os dados do produto");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            double valorTotalP = p.ValorTotalEmEstoque();
            Console.Write("Dados do Produto: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque:");
            int quantidade = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(quantidade);
            Console.Write("Dados atualizados: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removidos do estoque:");
            quantidade = int.Parse(Console.ReadLine());
            p.RemoverProdutos(quantidade);
            Console.Write("Dados do Produto: " + p);
        }
    }
}