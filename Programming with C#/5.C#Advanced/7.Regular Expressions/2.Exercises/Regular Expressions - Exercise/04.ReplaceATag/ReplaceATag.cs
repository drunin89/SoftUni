using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.ReplaceATag
{
    class ReplaceATag
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern = @"<a (href=.+?)>(.+)</a>";
            var regex = new Regex(pattern);

            while (input != "end")
            {
                var result = Regex.Replace(input, regex.ToString(), @"[URL $1]$2[/URL]");

                Console.WriteLine(result);

                input = Console.ReadLine();
            }

 

        }
    }
}
