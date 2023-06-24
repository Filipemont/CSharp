using System;
using System.Globalization;


namespace EstruturaWhile {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Digite um numero: ");
            double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while(num >=0) {
                double raiz = Math.Sqrt(num);
                Console.WriteLine($"A raiz é : {raiz.ToString("F3", CultureInfo.InvariantCulture)}");

                Console.Write("Digite um novo numero: ");
                num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Número Negativo");
        }
    }
}