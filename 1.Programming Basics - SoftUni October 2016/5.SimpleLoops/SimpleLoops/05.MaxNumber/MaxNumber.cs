using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MaxNumber
{
    class MaxNumber
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double max = -10000000000000;
            for (int i = 0; i < n; i++)
            {
                var num = double.Parse(Console.ReadLine());
                if (num > max)
                {
                    max = num;
                }

            }
            Console.WriteLine(max);
        }
    }
}
