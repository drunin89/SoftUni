using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.ExtractSentences
{
    class ExtractSentences
    {
        public static void Main()
        {
            var word = Console.ReadLine();
            var sentences = Console.ReadLine()
                .Split(new[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries)
                ;
            var pattern = "\\b" + word + "\\b";
            var regex = new Regex(pattern);
            foreach (var sen in sentences)
            {
                if (regex.IsMatch(sen))
                {
                    Console.WriteLine(sen.Trim());
                }
            }

        }
    }
}
