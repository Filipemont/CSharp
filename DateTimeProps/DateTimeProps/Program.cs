namespace DateTimeProps {
    internal class Program {
        static void Main(string[] args) {
            DateTime d = DateTime.Now;
            string s1 = d.ToLongDateString();
            string s2 = d.ToLongTimeString();
            string s3 = d.ToShortDateString();
            string s4 = d.ToShortTimeString();

            string s5 = d.ToString();

            string s6 = d.ToString("yyyy/MM/dd HH:mm:ss");
            string s7 = d.ToString("yyyy/MM/dd HH:mm:ss.fff");

            DateTime d2 = d.AddMonths(1);
            TimeSpan t = d2.Subtract(d);
            Console.WriteLine(t);


            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);
            Console.WriteLine(d);
            Console.WriteLine(d2);
           

        }
    }
}