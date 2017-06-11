using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _10.UseYourChainsBuddy
{
    class UseYourChainsBuddy
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine();
            var pattern = @"<p>(.*?)</p>";

            var regex = new Regex(pattern);

            var matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                var whiteSpaces = new Regex("[^a-z0-9]+");
                var reminder = match.Groups[1].Value;
                var replaced = Regex.Replace(reminder, whiteSpaces.ToString(), " ");
           
                var sb = new StringBuilder();
                foreach (var character in replaced)
                {
                    if (character >= 'a' && character <= 'm')
                    {
                        sb.Append((char)(character + 13));
                    }
                    else if (character >= 'n' && character <= 'z')
                    {
                        sb.Append((char)(character - 13));
                    }
                    else
                    {
                        sb.Append((char)character);
                    }
                }
                Console.Write(sb);
            }
            Console.WriteLine();
        }
    }
}
