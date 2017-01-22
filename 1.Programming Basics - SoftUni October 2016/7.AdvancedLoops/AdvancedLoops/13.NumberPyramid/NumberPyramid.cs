using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.NumberPyramid
{
    class NumberPyramid
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int end = 0;
            int q = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = q; j <= q + i - 1; j++)
                {
                    Console.Write("{0} ", j);
                    end = j;
                    if (end == n)
                    {
                        break;

                    }
                }
                if (end == n)
                {
                    break;
                }
                q = end + 1;
                Console.WriteLine();
            }
        }
    }
}
