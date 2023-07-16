using System;
using System.Globalization;

namespace Date {
    internal class Program {
        static void Main(string[] args) {
            DateTime d1 = new DateTime(2020, 01, 01);
            DateTime d2 = new DateTime(2020, 01, 01, 20, 45, 30);
            DateTime d3 = new DateTime(2020, 01, 01, 20, 45, 30, 500);

            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.Today;
            DateTime d6 = DateTime.UtcNow;

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);

            DateTime d7 = DateTime.Parse("2000-08-15");
            Console.WriteLine(d7);
            DateTime d8 = DateTime.Parse("2000-08-15 19:00:35");
            Console.WriteLine(d8);
            DateTime d9 = DateTime.Parse("20/05/1994 11:00:20");
            Console.WriteLine(d9);
            DateTime d10 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine(d10);
            DateTime d11 = DateTime.ParseExact("15/08/2023 10:05:23", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d11);

        }
    }
}