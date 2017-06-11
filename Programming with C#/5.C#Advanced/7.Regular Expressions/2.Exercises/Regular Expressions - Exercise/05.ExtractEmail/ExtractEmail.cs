using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.ExtractEmail
{
    class ExtractEmail
    {
        public static void Main()
        {
            var pattern = @"^[a-zA-Z0-9][\w-.]+@[a-zA-Z][a-zA-Z-]*(\.[a-zA-Z]+[a-zA-Z-]*?)+$";
            var regex = new Regex(pattern);

            var input = Console.ReadLine().Split().Select(x => x.TrimEnd(".,;:!?".ToCharArray()));

            foreach (var item in input)
            {
                if (Regex.IsMatch(item, pattern))
                {
                    Console.WriteLine(item);
                }
            }

        }
    }
}
