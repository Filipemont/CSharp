using System;
using System.Globalization;

namespace Arrays {
    internal class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            double[] altura = new double[n];
            double contador = 0;
            for(int i = 0; i < n; i++) {
                altura[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                contador += altura[i];
            }
            Console.WriteLine("Average Height: " + (contador / n).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}