using System;
using System.Globalization;

namespace ConversorDeMoedas {
    internal class ConversorDeMoedas {

        public static double iof = 0.06;
        public static double Conversor(double cotacao, double valor) {
            return (cotacao * valor + (cotacao * valor * iof));

        }

    }
}
