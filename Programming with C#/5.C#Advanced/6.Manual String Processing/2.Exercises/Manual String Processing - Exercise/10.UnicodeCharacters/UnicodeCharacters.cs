using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                string charToUnicode = "0000".Substring(0, 4 - ((int)(input[i])).ToString("x").Length) + ((int)(input[i])).ToString("x");
                Console.Write("\\u{0}", charToUnicode);
            }
        }

    }
}
