using System;
using System.Globalization;

namespace Questao2 {
    internal class Program {
        static void Main(string[] args) {
            double pi = 3.14159;
            Console.WriteLine("Qual o raio?");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = pi * Math.Pow(raio, 2);
            Console.WriteLine($"A={area.ToString("F4", CultureInfo.InvariantCulture)}");
        }
    }
}