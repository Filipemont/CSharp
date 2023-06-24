using System;

namespace AulaDois {
    class Program {
        static void Main(string[] args) {

            bool completo = false;
            char genero = 'f';
            char letra = '\u0041';
            byte x = byte.MinValue;
            int y = int.MinValue;
            int z = int.MaxValue;
            long l = 2147483648L;
            float f = 4.5f;
            double d = 4.5;
            string nome = "Maria Antonia";
            object obj1 = "Alex Brown";
            object obj2 = 4.5;
            decimal enorme = decimal.MaxValue;

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(l);
            Console.WriteLine(f);
            Console.WriteLine(d);
            Console.WriteLine(nome);
            Console.WriteLine(obj2);
            Console.WriteLine(obj1);
            Console.WriteLine(enorme);
            
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:f2} reais!", nome, f, z );
            
            Console.WriteLine($"{nome} tem {f} e tem saldo igual a {enorme} reais!");
            
            Console.WriteLine(nome + " tem" + f + " e tem saldo igual a " + enorme + " reais");
        }
    }
} 