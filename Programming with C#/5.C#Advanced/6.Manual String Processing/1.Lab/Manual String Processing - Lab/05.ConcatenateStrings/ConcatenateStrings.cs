using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ConcatenateStrings
{
    class ConcatenateStrings
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var sb = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                sb.Append(Console.ReadLine()).Append(" ");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
