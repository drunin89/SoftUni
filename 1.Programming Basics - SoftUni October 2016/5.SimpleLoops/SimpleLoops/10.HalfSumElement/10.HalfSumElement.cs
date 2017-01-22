using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double sum = 0;
            double max = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                var num = double.Parse(Console.ReadLine());
                sum += num;
                if (num > max)
                {
                    max = num;

                }

            }
            if (max == (sum - max))
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", sum - max);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", Math.Abs(max - (sum - max)));

            }
        }
    }
}
