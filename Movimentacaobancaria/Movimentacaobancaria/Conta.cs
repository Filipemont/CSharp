using System;
using System.Globalization;

namespace Movimentacaobancaria {
    internal class Conta {
        public int NumeroConta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }


        public Conta(string nome, int numeroConta) {
            Nome = nome;
            NumeroConta = numeroConta;
        }



        public Conta(string nome, int numeroConta, double depositoInicial) : this(nome, numeroConta) {
            AdicionarSaldo(depositoInicial);
        }


        public void AdicionarSaldo(double deposito) {
            Saldo += deposito;
        }

        public void Saque(double saque) {
            Saldo -= (saque + 5);
        }
        public override string ToString() {
            return "Conta " + NumeroConta + ", Titular: " + Nome + ", Saldo :$" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }

}


