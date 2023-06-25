using System;
using System.Globalization;

namespace Fixacao03 {
    internal class Aluno {
        public string Nome;
        public double nota1;
        public double nota2;
        public double nota3;

        public void NotaFinal(double nota, double nota1, double nota2) {
            double notaTotal = nota + nota1 + nota2;
            if(notaTotal >= 60) {
                Console.WriteLine("NOTA FINAL = " + notaTotal.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("APROVADO");
            } else {
                Console.WriteLine("NOTA FINAL = " + notaTotal.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"FALTARAM {(60 - notaTotal).ToString("F2", CultureInfo.InvariantCulture)} PONTOS");
            }

        }
    }
}
