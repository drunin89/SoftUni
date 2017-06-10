using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _04.ConvertFromBase10ToBaseN
{
    class ConvertFromBase10ToBaseN
    {
        public static void Main()
        {
            string[] inpit = Console.ReadLine().Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            int newBase = int.Parse(inpit[0]);
            BigInteger tenBased = BigInteger.Parse(inpit[1]);

            Console.WriteLine(ConvertToBase(tenBased, newBase));
        }

        private static BigInteger ConvertToBase(BigInteger tenBased, int newBase)
        {
            // 2 <= N <= 10
            if (newBase < 2 || newBase > 10)
            {
                throw new ArgumentException("N must be between 2 and 10 (including)");
            }

            StringBuilder sb = new StringBuilder();

            while (tenBased > 0)
            {
                sb.Insert(0, tenBased % newBase);
                tenBased /= newBase;
            }

            return BigInteger.Parse(sb.ToString());
        }
    }
}
