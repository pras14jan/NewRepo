using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program1
    {
        static void Main(string[] args)
        {
            var generators = new Func<string, int, string>[]
            {
        (s, i) => i % 3 == 0 ? s + "Fizz" : s,
        (s, i) => i % 5 == 0 ? s + "Buzz" : s,
        (s, i) => s ?? i.ToString()
            };
            var results = Enumerable.Range(1, 100).Select(i => generators.Aggregate((string)null, (s, f) => f(s, i))).ToList();
            results.ForEach(Console.WriteLine);

            Console.ReadKey();
        }
    }
}
