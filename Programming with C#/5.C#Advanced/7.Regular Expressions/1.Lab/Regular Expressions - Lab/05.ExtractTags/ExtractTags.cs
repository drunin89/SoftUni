using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.ExtractTags
{
    class ExtractTags
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"<.*?>");
            var input = Console.ReadLine();
            while (input != "END")
            {
                MatchCollection matches = regex.Matches(input);
                foreach (Match match in matches)
                {
                    Console.WriteLine(match);
                }
                input = Console.ReadLine();
            }

        }
    }
}
