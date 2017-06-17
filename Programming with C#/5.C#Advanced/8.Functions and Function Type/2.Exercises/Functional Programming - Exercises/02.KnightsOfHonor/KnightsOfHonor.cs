using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.KnightsOfHonor
{
    class KnightsOfHonor
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            Action<IEnumerable<string>> action = collection => Console.WriteLine(string.Join(Environment.NewLine, collection.Select(name => $"Sir {name}")));
            action(input);
        }
    }
}
