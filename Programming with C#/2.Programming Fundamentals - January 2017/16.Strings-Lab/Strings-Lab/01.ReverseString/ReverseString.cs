using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ReverseString
{
    class ReverseString
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var result = text.Reverse();
            Console.WriteLine(string.Join(null ,result));

        }
    }
}
