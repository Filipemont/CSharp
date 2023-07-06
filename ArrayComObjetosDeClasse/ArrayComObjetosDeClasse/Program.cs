using System;
using System.Globalization;

namespace ArrayComObjetosDeClasse {
    internal class Program {
        static void Main(string[] args) {
            int N = int.Parse(Console.ReadLine());

            Produto[] produto = new Produto[N];
            double precoMedio = 0.0;

            for (int i = 0; i < N; i++) {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                produto[i] = new Produto(nome, preco);
                precoMedio += produto[i].Preco;
            }
            
            Console.WriteLine("Preço médio é: " +(precoMedio/N).ToString("F2", CultureInfo.InvariantCulture));
        }

    }
}