using System;
using System.Globalization;
namespace ConversorDeMoedas {
    internal class Program {
        static void Main(string[] args) {
            double cotacao, valor, total;
            Console.Write("Qual é a cotação do dólar? ");
            cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            total = ConversorDeMoedas.Conversor(cotacao, valor);
            Console.Write("Valor a ser pago em reais = " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}