using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.ConvertBase_10ToBase_N
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split()
                .ToArray();

            var number = BigInteger.Parse(input[1]);
            var toBase = int.Parse(input[0]);

            var result = ConvertBase10ToBaseN(number, toBase);
            Console.WriteLine(result);

        }

        private static string ConvertBase10ToBaseN(BigInteger number, int toBase)
        {
            var result = string.Empty;
            while (number>0)
            {
                var remainNumber = number % toBase;
                result = remainNumber + result;
                number /= toBase;
            }
            return result;
        }
    }
}
