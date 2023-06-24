using System;
using System.Globalization;
namespace Questao2Classe {
    internal class Program {
        static void Main(string[] args) {
            Funcionario funcionario1, funcionario2;
            funcionario1 = new Funcionario();
            funcionario2 = new Funcionario();
            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            funcionario1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            funcionario2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double media = Media(funcionario2.Salario, funcionario1.Salario);
            Console.WriteLine("Salário médio:" + media.ToString("F2", CultureInfo.InvariantCulture));

        }
        static double Media(double a, double b) {
            double media = (a + b) / 2;
            return media;
        }
    }
}