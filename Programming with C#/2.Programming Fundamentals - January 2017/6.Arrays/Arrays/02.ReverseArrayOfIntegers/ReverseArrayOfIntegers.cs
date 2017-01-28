using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ReverseArrayOfIntegers
{
    class ReverseArrayOfIntegers
    {
        static void Main(string[] args)
        {
            // Read the array (a number n + n lines of integers)
            var n = int.Parse(Console.ReadLine());
            var arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            // Print the elements from the last to the first
            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
