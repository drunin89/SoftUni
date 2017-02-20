using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.ExtractEmails
{
    class ExtractEmails
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            var pattern = @"([\w-.]+\@[a-zA-z-]+)(\.[a-zA-Z-]+)+";
            var regex = new Regex(pattern);
            var matches = regex.Matches(input);
            foreach (var match in matches)
            {
                var matchString = match.ToString();
                if (!(matchString.StartsWith("-") 
                    || matchString.StartsWith("_") 
                    || matchString.StartsWith(".")
                    || matchString.EndsWith("-")
                    || matchString.EndsWith("_")
                    || matchString.EndsWith(".")
                    )) 
                {
                    Console.WriteLine(matchString);
                }
               
            }
            

        }
    }
}
