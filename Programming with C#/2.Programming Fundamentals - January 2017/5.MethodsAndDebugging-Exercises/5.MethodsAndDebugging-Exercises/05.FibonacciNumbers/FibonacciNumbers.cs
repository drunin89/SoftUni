using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(GetFibonachiNumber(n)); 
        }
        public static int GetFibonachiNumber(int n)
        {
            int f1 = 0;
            int f2 = 1;
            int f3;
            var result = 1;
            for (int i = 1; i <= n; i++)
            {
                f3 = f1 + f2;
                f1 = f2;
                f2 = f3;
                if (i == n)
                {
                    result = f3;
                }
              
            }
            return result;
        }
    }
}
