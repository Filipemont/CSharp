using System;
using System.Globalization;

namespace EntradaDeDados {
    internal class Program {
        static void Main(string[] args) {
            //Primeira Parte da Aula de Entrada de Dados:
            //string frase = Console.ReadLine(), x = Console.ReadLine(),
              //  y = Console.ReadLine(), z = Console.ReadLine();
           

            //string[] palavras = Console.ReadLine().Split(' ');
            //string a = palavras[0];
            //string b = palavras[1];
            //string c = palavras[2];

            //Console.WriteLine("Você digitou:");
            //Console.WriteLine(frase);
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);
            //Console.WriteLine($"{a} {b} {c}");
            //Console.WriteLine("----------------------------------------");
            //Segunda Parte de Entrada de Dados:

            int n1 = int.Parse(Console.ReadLine());
            char f = char.Parse(Console.ReadLine());
            float numero = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            string[] dados = Console.ReadLine().Split(' ');
            string nome = dados[0];
            char sexo = char.Parse(dados[1]);
            int idade = int.Parse(dados[2]);
            float altura = float.Parse(dados[3], CultureInfo.InvariantCulture);
            
            
            
            
            Console.WriteLine("Você digitou:");
            Console.WriteLine(n1);
            Console.WriteLine(f);
            Console.WriteLine(numero.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine($"{nome} {sexo} {idade} {altura.ToString("F2", CultureInfo.InvariantCulture)}");
 
        }
    }
}