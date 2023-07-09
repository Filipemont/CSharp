using System;
using System.Globalization;
using System.Collections.Generic;

namespace Listas1 {
    internal class Program {
        static void Main(string[] args) {
            List<string> list = new List<string>();
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Ana");
            list.Add("Bob");

            foreach (string nome in list) {
                Console.WriteLine(nome);
            }

            Console.WriteLine("------------------");

            list.Insert(2, "Marco");
            foreach (string nome in list) {
                Console.WriteLine(nome);
            }
            Console.WriteLine(list.Count);


            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine(s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine(s2);

            int s3 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine(s3);

            int s4 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine(s4);

            Console.WriteLine("----------FindALL---------------");

            List<string> list2 = list.FindAll(x => x.Length == 5);
            foreach (string nome in list2) {
                Console.WriteLine(nome);
            }
            list.Remove("Alex");
            Console.WriteLine("----------REMOVE---------------");

            foreach (string nome in list) {
                Console.WriteLine(nome);
            }
            Console.WriteLine("----------REMOVE ALL----------------");
            list.RemoveAll(x => x.Length == 5);
            foreach (string nome in list) {
                Console.WriteLine(nome);
            }

            Console.WriteLine("--------------REMOVE AT POSITION 2---------------");

            list.RemoveAt(1);
            foreach( string nome in list) {
                Console.WriteLine(nome);
            }
            Console.WriteLine("----------REMOVE RANGE----------");

            list.RemoveRange(0, 5);
            foreach( string nome in list) {
                Console.WriteLine(nome);
            }
        }
    }
}