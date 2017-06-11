using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.ExtractIntegerNumbers
{
    class ExtractIntegerNumbers
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Regex regex = new Regex("\\d+");
            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }

        }
    }
}
