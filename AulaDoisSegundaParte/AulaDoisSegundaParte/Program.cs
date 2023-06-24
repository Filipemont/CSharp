using System;

namespace AulaDoisSegundaParte {
    class Program {
        static void Main(string[] args) {
            int n1 = 3 + 4 * 2;
            int n2 = (3+4) * 2;
            int n3 = n2 % 3;
            float n4 = 10f / 8;

            double a = 1.0, b = -3.0, c = -4.0;

            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a),
                x2 = (-b - Math.Sqrt(delta)) / (2.0 *a);
             

            Console.WriteLine( n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine($"{x1}, {x2}, {delta}");
            
        }
    }
}