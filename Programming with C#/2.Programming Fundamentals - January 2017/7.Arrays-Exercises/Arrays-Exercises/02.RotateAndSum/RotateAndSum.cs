using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RotateAndSum
{
    class RotateAndSum
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int[] sum = new int[inputNumbers.Length];
            for (int i = 0; i < n; i++)
            {
                int lastNumber = inputNumbers[inputNumbers.Length - 1];
                for (int j = inputNumbers.Length-1; j >0; j--)
                {
                    inputNumbers[j] = inputNumbers[j - 1];
                }
                inputNumbers[0] = lastNumber;
                for (int j = 0; j < inputNumbers.Length; j++)
                {
                    sum[j] += inputNumbers[j];
                }
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
