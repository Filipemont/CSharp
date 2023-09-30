using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]numbers = Enumerable.Range(0, 10).ToArray();


            Console.WriteLine(numbers.Where(x => x % 2 != 0).Select(x => x*10).ToString());


        }
    }
}