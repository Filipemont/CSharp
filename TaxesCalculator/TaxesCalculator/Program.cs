using System;
using System.Globalization;
using TaxesCalculator.Entities;

namespace TaxesCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Taxes> list = new List<Taxes>();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char answer = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(answer == 'i' ||  answer == 'I')
                {
                    Console.Write("Health expenditures: ");
                    double expend = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new PhysicalTaxPayer(expend, name, income));
                }
                else if(answer == 'c' || answer == 'C')
                {
                    Console.Write("Number od employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    list.Add(new JuridicalTaxPayer(employees, name, income));
                }
            }
            Console.WriteLine();
            double totalTaxes = 0;
            Console.WriteLine("TAXES PAID:");
            foreach(Taxes tax in list)
            {
                Console.WriteLine(tax.Name + ": $ " + tax.AnualPaymentTaxes().ToString("F2", CultureInfo.InvariantCulture));
                totalTaxes+= tax.AnualPaymentTaxes();
            }
            Console.WriteLine();
            Console.Write("TOTAL TAXES: $ " + totalTaxes.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}