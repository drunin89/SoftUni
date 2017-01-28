using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ReverseArrayOfStrings
{
    class ReverseArrayOfStrings
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(' ').ToArray();
            Array.Reverse(text);
            Console.WriteLine(string.Join(" ", text));
        }
    }
}
