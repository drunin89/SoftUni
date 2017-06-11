using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.SeriesOfLetters
{
    class SeriesOfLetters
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern = @"([A-Za-z])\1+";
            var regex = new Regex(pattern);

            Console.WriteLine(Regex.Replace(input, pattern, "$1"));
        }
    }
}
