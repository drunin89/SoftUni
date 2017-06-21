using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.BoundedNumbers
{
    class BoundedNumbers
    {
        static void Main(string[] args)
        {
            var boundaries = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            if (boundaries.Length != 2)
            {
                return;
            }

            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(n => n >= boundaries[0] && n <= boundaries[1] ||
                            n >= boundaries[1] && n <= boundaries[0])
                .ToArray();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
