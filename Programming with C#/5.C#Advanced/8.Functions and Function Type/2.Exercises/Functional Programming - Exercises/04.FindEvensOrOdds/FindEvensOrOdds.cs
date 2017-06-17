using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FindEvensOrOdds
{
    class FindEvensOrOdds
    {
        static void Main(string[] args)
        {
            var rangeBorders = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var command = Console.ReadLine();

            var numbers = Enumerable.Range(rangeBorders[0], rangeBorders[1] - rangeBorders[0] + 1);


            Predicate<int> isEven = n => n % 2 == 0;
            PrintChoosenNums(numbers, command, isEven);


        }

        private static void PrintChoosenNums(IEnumerable<int> numbers, string command, Predicate<int> isEven)
        {
            List<int> result = new List<int>();
            foreach (var number in numbers)
            {
                if (isEven(number) && command == "even")
                {
                    result.Add(number);
                }
                else if (!isEven(number) && command == "odd")
                {
                    result.Add(number);
                }
            }

            Console.WriteLine(String.Join(" ", result));
        }
    }
}
