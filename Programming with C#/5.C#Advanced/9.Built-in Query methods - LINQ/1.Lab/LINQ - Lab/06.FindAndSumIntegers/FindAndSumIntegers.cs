using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FindAndSumIntegers
{
    class FindAndSumIntegers
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(str =>
                {
                    double number;
                    var isNumber = double.TryParse(str, out number);
                    return new { number, isNumber };
                })
                .Where(obj => obj.isNumber)
                .Select(obj => obj.number)
                .ToArray();

            Console.WriteLine(numbers.Length == 0
                ? "No match"
                : $"{numbers.Sum()}");
        }
    }
}
