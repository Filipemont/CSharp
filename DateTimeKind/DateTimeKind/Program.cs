namespace Date {
    internal class Program {
        static void Main(string[] args) {
            DateTime d1 = new DateTime(2000, 08, 15, 13, 4, 58, DateTimeKind.Local);
            DateTime d2 = new DateTime(2000, 08, 15, 13, 4, 58, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2000, 08, 15, 13, 4, 58);
            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 kind: " + d1.Kind);
            Console.WriteLine("d1 To Local: " + d1.ToLocalTime());
            Console.WriteLine("d1 To UIniversal: " + d1.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 kind: " + d2.Kind);
            Console.WriteLine("d2 To Local: " + d2.ToLocalTime());
            Console.WriteLine("d2 To UIniversal: " + d2.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d3: " + d3);
            Console.WriteLine("d3 kind: " + d3.Kind);
            Console.WriteLine("d3 To Local: " + d3.ToLocalTime());
            Console.WriteLine("d3 To UIniversal: " + d3.ToUniversalTime());
            Console.WriteLine();

            Console.WriteLine("-----------------ISO 8601------------------");

            DateTime d4 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d5 = DateTime.Parse("2000-08-15T13:05:58Z");
            Console.WriteLine("d4: " + d4);
            Console.WriteLine("d4 kind: " + d4.Kind);
            Console.WriteLine("d4 To Local: " + d4.ToLocalTime());
            Console.WriteLine("d4 To UIniversal: " + d4.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d5: " + d5);
            Console.WriteLine("d5 kind: " + d5.Kind);
            Console.WriteLine("d5 To Local: " + d5.ToLocalTime());
            Console.WriteLine("d5 To UIniversal: " + d5.ToUniversalTime());
            Console.WriteLine();

        }
    }
}