using System;
using System.Globalization;

namespace Fixacao02 {
    internal class Funcionario {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido(double salario, double imposto) {
            return salario - imposto;
        }
        public void AumentarSalario(double porcentagem) {
            SalarioBruto += (SalarioBruto * (porcentagem/100));
        }

        public override string ToString() {
            return Nome + ", $ " + SalarioLiquido(SalarioBruto, Imposto).ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
