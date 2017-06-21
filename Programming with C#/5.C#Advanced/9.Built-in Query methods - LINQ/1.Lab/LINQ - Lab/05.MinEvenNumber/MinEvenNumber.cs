using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MinEvenNumber
{
    class MinEvenNumber
    {
        static void Main(string[] args)
        {
            var evenNumbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .Where(n => n % 2 == 0)
                .ToArray();

            Console.WriteLine(evenNumbers.Length == 0
                ? "No match"
                : $"{evenNumbers.Min():F2}");

        }
    }
}
