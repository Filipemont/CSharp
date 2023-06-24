using System;
using System.Globalization;
namespace Questao04 {
    internal class Program {
        static void Main(string[] args) {
            int numeroDoFuncionario = int.Parse(Console.ReadLine());
            int horasTrabalhadas = int.Parse(Console.ReadLine());
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salario = valorHora * horasTrabalhadas;
            Console.WriteLine("Number = " + numeroDoFuncionario);
            Console.WriteLine($"Salary = U$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}