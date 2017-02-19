using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _02.ConvertFromBase_NToBase_10
{
    class Program
    {
        private static int i;

        public static void Main()
        {
            var input = Console.ReadLine()
               .Split()
               .ToArray();

            var number = BigInteger.Parse(input[1]);
            var toBase = int.Parse(input[0]);

            var result = ConvertBaseNToBase10(number, toBase);
            Console.WriteLine(result);

        }

        private static BigInteger ConvertBaseNToBase10(BigInteger number, int toBase)
        {
            var numberAsString = number.ToString();
            var sum = new BigInteger(0);
            for (int power = 0; power < numberAsString.Length; power++)
            {
                var num = int.Parse(numberAsString[numberAsString.Length - 1 - power].ToString());
                var result = num * BigInteger.Pow(toBase, power);
                sum += result;
            }
            return sum;
        }

    }
}
