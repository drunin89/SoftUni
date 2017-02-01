using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var longestNumbers = new List<int>();
            var currentNumbers = new List<int>();
            currentNumbers.Add(numbers[0]);
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == currentNumbers[0])
                {
                    currentNumbers.Add(numbers[i]);
                }
                else
                {
                    if (currentNumbers.Count > longestNumbers.Count)
                    {
                        longestNumbers.Clear();
                        longestNumbers.AddRange(currentNumbers);
                    }
                    currentNumbers.Clear();
                    currentNumbers.Add(numbers[i]);
            
                }
            }
            if (currentNumbers.Count > longestNumbers.Count)
            {
                longestNumbers.Clear();
                longestNumbers.AddRange(currentNumbers);
            }
                     Console.WriteLine(string.Join(" ", longestNumbers));
        }

    }
}
