using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.RageQuit
{
    class RageQuit
    {
        public static void Main()
        {
            var pattern = @"(\D+)(\d+)";
            var regex = new Regex(pattern);
            var inputLine = Console.ReadLine().ToUpper();
            var matches = regex.Matches(inputLine);
            var uniqueCharactes = new HashSet<char>();
            var outputResult = new StringBuilder();
            foreach (Match match in matches)
            {
                var message = match.Groups[1].Value;
                var repeat = int.Parse(match.Groups[2].Value);
                for (int i = 0; i < message.Length; i++)
                {
                    if (!uniqueCharactes.Contains(message[i]))
                    {
                        uniqueCharactes.Add(message[i]);
                    }
                }
                for (int i = 0; i < repeat; i++)
                {
                    outputResult.Append(message);
                }
            }

            Console.WriteLine($"Unique symbols used: {outputResult.ToString().Distinct().Count()}");
            Console.WriteLine(outputResult.ToString());
        }
    }
}
