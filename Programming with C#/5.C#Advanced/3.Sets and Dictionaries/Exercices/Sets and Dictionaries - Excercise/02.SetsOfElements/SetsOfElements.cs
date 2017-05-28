using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SetsOfElements
{
    class SetsOfElements
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split(' ').ToArray();
            var n1 = int.Parse(line[0]);
            var n2 = int.Parse(line[1]);
            var firstNumbers = new List<int>();
            var resultNumbers = new List<int>();

            for (int i = 1; i <= n1; i++)
            {
                firstNumbers.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 1; i <= n2; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (firstNumbers.Contains(number))
                {
                    resultNumbers.Add(number);
                }
            }
            Console.WriteLine(string.Join(" ", resultNumbers));
        }
    }
}
