using System;
using System.Globalization;

namespace Fixacao01 {
    internal class Program {
        static void Main(string[] args) {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo:");
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Area = " + retangulo.Area(retangulo.Altura, retangulo.Largura));
            Console.WriteLine("Perímetro = " + retangulo.Perimetro(retangulo.Altura, retangulo.Largura));
            Console.WriteLine("Diagonal = " + retangulo.Diagonal(retangulo.Altura, retangulo.Largura));
        }
    }
}