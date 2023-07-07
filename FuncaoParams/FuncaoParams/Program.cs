namespace FuncaoParams {
    internal class Program {
        static void Main(string[] args) {

            int s1 = Calculadora.Sum(2, 3);

            int s2 = Calculadora.Sum(2, 3,4);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}