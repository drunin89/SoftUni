using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CountUppercaseWords
{
    class CountUppercaseWords
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(new string[] { " " },
                 StringSplitOptions.RemoveEmptyEntries);

            Func<string, bool> checker = n => n[0] == n.ToUpper()[0];

            words.Where(checker)
                 .ToList()
                 .ForEach(n => Console.WriteLine(n));

        }
    }
}
