using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.OddEvenSum
{
    class OddEvenSum
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;
            for (var i = 0; i < n; i++)
            {
                var element = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += element;

                }
                else
                {
                    oddSum += element;
                }
            }
            if (oddSum == evenSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", evenSum);
            }
            else if (oddSum > evenSum)
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", oddSum - evenSum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", evenSum - oddSum);
            }
        }
    }
}
