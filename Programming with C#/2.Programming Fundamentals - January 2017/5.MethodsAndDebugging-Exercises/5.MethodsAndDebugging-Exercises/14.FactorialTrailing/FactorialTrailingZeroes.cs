using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _13.Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            short n = short.Parse(Console.ReadLine());
            Console.WriteLine(GetFactoriel(n));
        }
        public static BigInteger GetFactoriel(short n)
        {
            BigInteger result = 1;
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            for (int i = n; i >= 0; i--)
            {
                if (result % 10 == 0)
                {
                    count += 1;
                    result /= 10;
                }
            }
            return count;
        }
    }
}
