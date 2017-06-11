using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.SentenceExtractor
{
    class SentenceExtractor
    {
        static void Main()
        {
            var key = Console.ReadLine();
            var text = Console.ReadLine();
            var matches = Regex.Matches(text, $@"[^.!?]+?\b{key}\b[^.!?]+?[!?.]", RegexOptions.IgnoreCase);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
