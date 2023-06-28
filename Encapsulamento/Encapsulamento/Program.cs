using System.Globalization;

namespace Encapsulamento {
    internal class Program {
        static void Main(string[] args) {
            Produto p = new Produto("TV", 500.00, 10);

            Console.WriteLine(p.GetNome());
            string nome = Console.ReadLine();
            p.SetNome(nome); 
            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetQuantidade());
            Console.WriteLine(p.GetPreco());
        }

    }
}