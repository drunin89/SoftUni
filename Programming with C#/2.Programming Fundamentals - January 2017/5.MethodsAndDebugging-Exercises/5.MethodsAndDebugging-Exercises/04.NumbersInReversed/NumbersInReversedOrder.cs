using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NumbersInReversed
{
    class NumbersInReversedOrder
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            GetReversedNumber(input);
        }
        public static void GetReversedNumber(string input)
        {

            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }
            Console.WriteLine();
        }
    }
}
