using System.Runtime.Serialization.Formatters;

namespace MatrizFixacao {
    internal class Program {
        static void Main(string[] args) {
            string[] valores = Console.ReadLine().Split(' ');
            int m = int.Parse(valores[0]);
            int n = int.Parse(valores[1]);

            int[,] matriz = new int[m, n];

            for (int i = 0; i < m; i++) {
                string[] valoresMatriz = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    matriz[i, j] = int.Parse(valoresMatriz[j]);
                }
            }
            int X = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    if (matriz[i, j] == X) {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        if (j > 0) {
                            Console.WriteLine("Left: " + matriz[i, j - 1]);
                        }
                        if (i > 0) {
                            Console.WriteLine("Up: " + matriz[i - 1, j]);
                        }
                        if (j < n - 1) {
                            Console.WriteLine("Right: " + matriz[i, j + 1]);
                        }
                        if (i < m - 1) {
                            Console.WriteLine("Down: " + matriz[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}