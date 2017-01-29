using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(ushort.Parse).ToArray();
            int[] counter = new int[65536];

            foreach (ushort num in numbers)
            {
                counter[num]++;
            }

            int maxValue = counter.Max();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (counter[numbers[i]] == maxValue)
                {
                    Console.WriteLine(numbers[i]);
                    return;
                }
            }


        }
    }
}
