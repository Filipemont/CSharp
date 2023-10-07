using ConsoleApp1.Entities;
using System.Globalization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o endereço do arquivo?");
            string caminho = Console.ReadLine();
            Console.WriteLine("Qual o salario?");
            double salario = double.Parse(Console.ReadLine());

            List<funcionario> funcionarios = new List<funcionario>();

            using (StreamReader sr = File.OpenText(caminho))
            {
                while(!sr.EndOfStream) {
                    string[] suporte = sr.ReadLine().Split(',');
                    string nome = suporte[0];
                    string mail = suporte[1];
                    double salarioLista = double.Parse(suporte[2], CultureInfo.InvariantCulture);

                    funcionarios.Add(new funcionario(nome, mail, salarioLista));
                }
            }


            var email = funcionarios.Where(p => p.Salario > salario).Select(p => p.Email);


            Console.WriteLine("Email de quam recebe acima do valor estipulado:");
            foreach (string emails in email)
            {
                Console.WriteLine(emails);
            }


            var somaSalario = funcionarios.Where(p => p.Nome[0] == 'M').Select(p => p.Salario).Sum();
                

            Console.WriteLine("A soma dos salarios de quem começa o nome com a letra M é : " + somaSalario);
        }
    }
}