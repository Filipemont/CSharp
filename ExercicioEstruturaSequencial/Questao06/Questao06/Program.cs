using System;
using System.Globalization;

//Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre: 
//a) a área do triângulo retângulo que tem A por base e C por altura. 
//b) a área do círculo de raio C. (pi = 3.14159) 
//c) a área do trapézio que tem A e B por bases e C por altura. 
//d) a área do quadrado que tem lado B. 
//e) a área do retângulo que tem lados A e B.

namespace Questao06 {
    internal class Program {
        static void Main(string[] args) {
            string[] valores = Console.ReadLine().Split(' ');
            double A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double C = double.Parse(valores[2], CultureInfo.InvariantCulture);
            double areaTraiguloRetangulo = (A * C) / 2;
            double areaCirculo = 3.14159 * Math.Pow(C, 2);
            double areaTrapezio = ((A + B) * C) / 2;
            double areaQuadrado = Math.Pow(B, 2);
            double areaRetangulo = A * B;

            Console.WriteLine($"Triângulo: {areaTraiguloRetangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Circullo: {areaCirculo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Trapézio: {areaTrapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Quadrado: {areaQuadrado.ToString("F3",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Retângulo: {areaRetangulo.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}