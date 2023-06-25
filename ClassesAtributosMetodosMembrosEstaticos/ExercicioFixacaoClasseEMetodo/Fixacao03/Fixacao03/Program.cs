using System;
using System.Globalization;

namespace Fixacao03 {
    internal class Program {
        static void Main(string[] args) {
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            aluno.NotaFinal(aluno.nota1, aluno.nota2, aluno.nota3);
        }
    }
}