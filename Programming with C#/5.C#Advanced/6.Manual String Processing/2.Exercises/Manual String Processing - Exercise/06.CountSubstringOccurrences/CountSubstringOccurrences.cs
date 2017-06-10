using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CountSubstringOccurrences
{
    class CountSubstringOccurrences
    {
        public static void Main()
        {
            var text = Console.ReadLine().ToLower();
            var key = Console.ReadLine().ToLower();

            Console.WriteLine(KeyOccurances(text, key));
        }

        private static int KeyOccurances(string text, string key)
        {
            var indexOfKey = text.IndexOf(key);
            var occurances = 0;

            while (indexOfKey >= 0)
            {
                occurances++;
                indexOfKey = text.IndexOf(key, indexOfKey + 1);
            }

            return occurances;
        }
    }
}
