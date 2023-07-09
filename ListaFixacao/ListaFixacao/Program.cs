using System;
using System.Globalization;
using System.Collections.Generic;
using System.Xml.Linq;

namespace ListaFixacao {
    internal class Program {
        static void Main(string[] args) {
            
            
            Console.Write("How many employess will be registered?");
            int quantidadeEmpregados = int.Parse(Console.ReadLine());
            List<Empregados> lista = new List<Empregados>();

            for (int i = 1; i <= quantidadeEmpregados; i++) {
                Console.WriteLine("Employee #" + i + ": ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                lista.Add(new Empregados(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase : ");
            int idAumento = int.Parse(Console.ReadLine());

            Empregados emp = lista.Find(x => x.Id == idAumento);
            if (emp != null) {
                Console.WriteLine("Enter the percentage: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.calculoAumento(porcentagem);
            } else {
                Console.WriteLine("This Id doesn`t exist!");
            }
            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach(Empregados empregados in lista) {
                Console.WriteLine(empregados);
            }


        }
    }
}