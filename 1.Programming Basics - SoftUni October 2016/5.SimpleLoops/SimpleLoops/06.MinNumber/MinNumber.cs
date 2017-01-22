using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MinNumber
{
    class MinNumber
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double min = 10000000000000;
            for (int i = 0; i < n; i++)
            {
                var num = double.Parse(Console.ReadLine());
                if (num < min)
                {
                    min = num;
                }

            }
            Console.WriteLine(min);
        }
    }
}
