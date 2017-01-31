using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RemoveNegativesAndReverse
{
    class RemoveNegativesAndReverse
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            numbers.Reverse();
            int count = 0;
            if (numbers.Count < 1)
            {
                Console.WriteLine("empty");
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 0)
                {

                }
                else
                {
                    Console.Write($"{numbers[i]} ");
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("empty");
            }
            Console.WriteLine();

        }
    }
}
