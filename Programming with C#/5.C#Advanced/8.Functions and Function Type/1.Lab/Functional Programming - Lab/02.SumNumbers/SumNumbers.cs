using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SumNumbers
{
    class SumNumbers
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine();

            Func<string, int> parser = n => int.Parse(n);
            var count = numbers.Split(new string[] { ", " },
                              StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(count.Length);
            Console.WriteLine(numbers.Split(new string[] { ", " },
                              StringSplitOptions.RemoveEmptyEntries)
                                     .Select(parser)
                                     .Sum());

        }
    }
}
