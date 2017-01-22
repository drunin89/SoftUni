using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Distance
{
    class Distance
    {
        static void Main(string[] args)
        {
            int sp = int.Parse(Console.ReadLine());
            double min1 = int.Parse(Console.ReadLine());
            double min2 = int.Parse(Console.ReadLine());
            double min3 = int.Parse(Console.ReadLine());
            double result = 0;
            double sp2 = sp * 1.1;
            double sp3 = sp2 * 0.95;
            double km1 = min1 / 60 * sp;
            double km2 = min2 / 60 * sp2;
            double km3 = min3 / 60 * sp3;

            result = km1 + km2 + km3;
            Console.WriteLine("{0:f2}", result);

        }
    }
}
