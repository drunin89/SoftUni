using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.ValidUsernames
{
    class ValidUsernames
    {
        static void Main()
        {
            Regex regex = new Regex(@"^[\w\d-]{3,16}$");
            var input = Console.ReadLine();
            while (input != "END")
            {
                MatchCollection matches = regex.Matches(input);
                if (matches.Count > 0)
                {
                    Console.WriteLine("valid");
                }
                else
                {
                    Console.WriteLine("invalid");
                }
                

                input = Console.ReadLine();
            }

        }
    }
}
