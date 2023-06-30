using System;
using System.Globalization;

namespace Movimentacaobancaria {
    internal class Program {
        static void Main(string[] args) {
            Conta novaConta;

            Console.Write("Entre o número da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resposta = char.Parse(Console.ReadLine());
            if (resposta == 's' || resposta == 'S') {
                Console.Write("Entre o valor do deposito inicial?");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                novaConta = new Conta(nome, conta, depositoInicial);
            } else {
                novaConta = new Conta(nome, conta);
            }

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(novaConta);
            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            novaConta.AdicionarSaldo(double.Parse(Console.ReadLine()));
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(novaConta);
            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            novaConta.Saque(double.Parse(Console.ReadLine()));
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(novaConta);
            
        }
    }
}