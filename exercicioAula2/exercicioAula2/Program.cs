using System;
using System.Globalization;

namespace ExercicioAula2 {
    class Program {
        static void Main(string[] args) {
            string produto1 = "Computador";
            string produto2 = "Mesa de Escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é $ {preco1}");
            Console.WriteLine($"{produto2}, cujo preco é $ {preco2}");
            Console.WriteLine();
            Console.WriteLine($"{idade} anos de idade, codigo {codigo} e genero: {genero}");
            Console.WriteLine();
            Console.WriteLine($"Medida com oito casas decimenais {medida:F8}");
            Console.WriteLine($"Arredondado(Três casas decimais): {medida:F3}");
            Console.WriteLine("Separador decimal invariant cultura: " + medida.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
