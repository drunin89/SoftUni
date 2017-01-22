using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.EqualPairs
{
    class EqualPairs
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double n1 = 0;
            double n2 = 0;
            double sum1 = 0;
            double sum2 = 0;
            double razlika = 0;
            for (int i = 1; i <= n; i++)
            {
                sum2 = sum1;
                n1 = double.Parse(Console.ReadLine());
                n2 = double.Parse(Console.ReadLine());
                sum1 = n1 + n2;
                if (i == 1)
                {
                }
                else if (sum1 == sum2)
                {
                }
                else if (sum1 > sum2)
                {
                    razlika = sum1 - sum2;
                }
                else
                {
                    razlika = sum2 - sum1;
                }
            }
            if (razlika == 0)
            {
                Console.WriteLine("Yes, value={0}", sum1);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}", razlika);
            }
        }
    }
}
