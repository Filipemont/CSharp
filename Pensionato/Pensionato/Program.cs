using System.Globalization;

namespace Pensionato {
    internal class Program {
        static void Main(string[] args) {

            Quartos[] quartos = new Quartos[10];
            
            Console.WriteLine("Quantos quartos vão ser alugados?");
            int quantQuartos = int.Parse(Console.ReadLine());

            for(int i = 0; i < quantQuartos; i++) {
                Console.WriteLine("aluguel #" + (i+1) + ":");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("E-mail: " );
                string email = Console.ReadLine();
                Console.Write("Numero do quarto: ");
                int numeroQuarto = int.Parse(Console.ReadLine());
                quartos[numeroQuarto] = new Quartos(nome, email, numeroQuarto);
                
            }
            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < quartos.Length; i++) {
                if (quartos[i] != null) {
                    Console.WriteLine(quartos[i].ToString());
                }
            }
        }
    }
}