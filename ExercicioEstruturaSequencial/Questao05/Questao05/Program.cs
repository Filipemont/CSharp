using System;
using System.Globalization;
using System.Runtime.Intrinsics.X86;

namespace Questao05 {
    internal class Program {
        static void Main(string[] args) {
            //Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o 
            //código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.Calcule e mostre o valor a ser pago.
            string[] peca1 = Console.ReadLine().Split(' ');
            int codigoPeca1 = int.Parse(peca1[0]);
            int quantidadePeca1 = int.Parse(peca1[1]);
            float valorPeca1 = float.Parse(peca1[2], CultureInfo.InvariantCulture);
            string[] peca2 = Console.ReadLine().Split(' ');
            int codigoPeca2 = int.Parse(peca2[0]);    
            int quantidadePeca2 = int.Parse(peca2[1]);
            float valorPeca2 = float.Parse(peca2[2], CultureInfo.InvariantCulture);
            float totalPeca1 = valorPeca1 * (float)quantidadePeca1;
            float totalPeca2 = valorPeca2 * (float)quantidadePeca2;
            Console.WriteLine($"VALOR A PAGAR: R${(totalPeca1 + totalPeca2).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}