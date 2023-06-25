using System;
using System.Globalization;

namespace Fixacao02 {
    internal class Program {
        static void Main(string[] args) {
            Funcionario funcionario = new Funcionario();

            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           
            Console.Write("Funcionário: " + funcionario);
            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salario: ");
            double aumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            funcionario.AumentarSalario(aumento);

            Console.Write("Dados atualizados: " + funcionario);

        }
    }
}