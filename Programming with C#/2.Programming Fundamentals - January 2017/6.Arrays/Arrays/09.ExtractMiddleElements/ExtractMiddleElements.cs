using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ExtractMiddleElements
{
    class ExtractMiddleElements
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = numbers.Length;
            int middle = 0;
            if (n == 1)
            {
                Console.WriteLine(numbers[0]);
            }
            else if (n % 2 == 0)
            {
                middle = n / 2;
                Console.WriteLine(new string('{' , 1) + string.Join(" , ", numbers[middle-1], numbers[middle]) + new string('}', 1));
            }
            else
            {
                middle = n / 2;
                Console.WriteLine(new string('{', 1) + string.Join(" , ", numbers[middle-1], numbers[middle], numbers[middle + 1]) + new string('}', 1));
            }
        }
    }
}
