using System;
using System.Globalization;
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
            Console.Write($"Dados do produto:{p.Nome}, ${p.Preco.ToString("F2", CultureInfo.InvariantCulture)}, {p.Quantidade} unidades,Total: $" + valorTotalP);
        }
    }
}