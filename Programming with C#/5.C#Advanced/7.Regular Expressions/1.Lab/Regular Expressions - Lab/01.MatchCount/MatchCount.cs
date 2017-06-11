using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _01.MatchCount
{
    class MatchCount
    {
        static void Main(string[] args)
        {
            string pattern = Console.ReadLine();
            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            Console.WriteLine(matches.Count);


        }
    }
}
