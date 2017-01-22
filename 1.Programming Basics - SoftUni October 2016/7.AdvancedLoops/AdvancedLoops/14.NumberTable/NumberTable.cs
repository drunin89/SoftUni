using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.NumberTable
{
    class NumberTable
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    num = i + j;
                    if (num > n)
                    {
                        num = 2 * n - num;
                    }
                    Console.Write("{0} ", num);
                }
                num = i;
                Console.WriteLine();
            }
        }
    }
}
