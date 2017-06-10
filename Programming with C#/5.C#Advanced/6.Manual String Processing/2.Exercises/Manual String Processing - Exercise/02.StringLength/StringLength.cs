using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StringLength
{
    class StringLength
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();

            if (str.Length > 20)
            {
                str = str.Substring(0, 20);
            }

            Console.WriteLine($"{str.PadRight(20, '*')}");
        }
    }
}
