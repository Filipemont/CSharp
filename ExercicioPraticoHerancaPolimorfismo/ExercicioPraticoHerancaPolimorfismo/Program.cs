using System;
using System.Collections.Generic;
using System.Globalization;
using ExercicioPraticoHerancaPolimorfismo.Entities;

namespace ExercicioPraticoHerancaPolimorfismo {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            List<Product> list = new List<Product>();
            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)?");
                char answer = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("PriceÇ ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (answer == 'i' || answer == 'I') {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customsFee));
                }
                else if(answer == 'u' || answer == 'U') {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime d = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, d));
                } else if (answer == 'c' || answer == 'C') {
                    list.Add( new Product(name, price));
                } else {
                    Console.WriteLine("This type doesn`t exist, try again!");
                    i--;
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine("Price Tags:");
            foreach (Product prod in list) {
                
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}