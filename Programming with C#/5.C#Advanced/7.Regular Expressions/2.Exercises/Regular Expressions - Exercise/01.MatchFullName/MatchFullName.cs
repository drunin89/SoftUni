using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.MatchFullName
{
    class MatchFullName
    {
        public static void Main()
        {
            var sb = new StringBuilder();
            var input = Console.ReadLine();

            while (input != "end")
            {
                sb.Append($"{input}{Environment.NewLine}");
                input = Console.ReadLine();
            }

            var regex = new Regex(@"\b([A-Z][a-z]+) ([A-Z][a-z]+)\b");
            var matches = regex.Matches(sb.ToString());

            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
