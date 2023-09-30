using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]numbers = Enumerable.Range(1, 10).Select(x => x * 2 -1).ToArray();            
            Array.ForEach(numbers, x => Console.WriteLine(x+ " "));

            //IEnumerable<int> result = numbers.Where(x => x % 2 != 0).Select(x => x*10);
        }
    }
}