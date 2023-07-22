using System;
using System.Collections.Generic;
using System.Globalization;
using Polimorfismo.Entities;

namespace Polimorfismo
{
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Enter the number of employess: ");
            int employessQuant = int.Parse(Console.ReadLine());
            List<Employee> List = new List<Employee>();
            for (int i = 0; i < employessQuant; i++) {
                Console.WriteLine("Employee #" + (i + 1) + " data:");
                Console.Write("Outsourced(y/n)? ");
                string answer = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (answer == "Y" || answer == "y") {
                    Console.Write("Addicional charge: ");
                    double addicionalCharge = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    List.Add(new OutsourcedEmployee(name, hours, valuePerHours, addicionalCharge));
                } else {
                    List.Add(new Employee(name, hours, valuePerHours));
                }
             }
            Console.WriteLine();
            Console.WriteLine("Payments: ");
            foreach (Employee emp in List) {
                Console.WriteLine(emp.Name + " -  $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}