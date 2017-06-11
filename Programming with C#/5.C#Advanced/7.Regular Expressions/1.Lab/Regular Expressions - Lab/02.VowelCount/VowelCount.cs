using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.VowelCount
{
    class VowelCount
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Regex regex = new Regex("[AEIOUYaeiouy]");
            MatchCollection matches = regex.Matches(input);

            Console.WriteLine($"Vowels: {matches.Count}");

        }
    }
}
