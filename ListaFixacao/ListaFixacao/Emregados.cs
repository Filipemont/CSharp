using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ListaFixacao {
    internal class Empregados {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Empregados(int id, string nome, double salario) {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void calculoAumento(double aumento) {
            Salario += Salario * (aumento/100);
        }
        public override string ToString() {
            return Id + ", " + Nome + ", " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
