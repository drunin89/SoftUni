using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08.ExtractHyperlinks
{
    public class ExtractHyperlinks
    {
        public static void Main()
        {
            var html = ReadInput();

            // This works to <a[\s\S]*?\s+href\s*={0,1}\s*([""'])?([\s\S]*?)(>|class|\1)[\s\S]*?<\/a>
            var matches = Regex.Matches(html,
                @"<a[\s\S]*?\s+href\s*={0,1}\s*([""'])?([\s\S]*?)(?:>|class|\1)[\s\S]*?<\/a>");

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[2].Value);
            }
        }

        private static string ReadInput()
        {
            var sb = new StringBuilder();
            var input = Console.ReadLine();

            while (input != "END")
            {
                sb.Append(input);
                input = Console.ReadLine();
            }

            return sb.ToString();
        }
    }
}


