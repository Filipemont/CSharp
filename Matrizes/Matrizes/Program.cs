namespace Matrizes {
    internal class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            double[,] mat = new double[n, n];

            int numerosNegativos = 0;
            for (int i = 0; i < n; i++) {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    mat[i, j] = double.Parse(valores[j]);
                    if (mat[i, j] < 0) { numerosNegativos++; };
                }
            }
            Console.WriteLine("Diagonal Principal:");
            for (int i = 0; i < n; i++) {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();
            Console.Write("Números negativos = " + numerosNegativos);
        }
    }
}