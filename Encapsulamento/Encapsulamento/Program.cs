using System.Globalization;

namespace Encapsulamento {
    internal class Program {
        static void Main(string[] args) {
            Produto p = new Produto("TV", 500.00, 10);

            Console.WriteLine(p.Nome);
            p.Nome = Console.ReadLine();
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Quantidade);
            Console.WriteLine(p.Preco);
        }

    }
}