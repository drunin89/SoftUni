using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.LeftAndRightSum
{
    class LeftAndRightSum
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;
            for (var i = 0; i < n; i++)
            {
                leftSum = leftSum + int.Parse(Console.ReadLine());
            }
            for (var i = 0; i < n; i++)
            {
                rightSum = rightSum + int.Parse(Console.ReadLine());
            }
            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes, sum = " + leftSum);
            }
            else
            {
                Console.WriteLine("No, diff = " + Math.Abs(rightSum - leftSum));
            }
        }
    }
}
