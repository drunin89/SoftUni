using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BombNumbers
{
    class BombNumbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] bombs = Console.ReadLine().Split();

            int number = int.Parse(bombs[0]);
            int power = int.Parse(bombs[1]);

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == number)
                {
                    int left = Math.Max(i - power, 0);

                    int right = Math.Min(i + power, numbers.Count - 1);

                    int lenght = right - left + 1;
                    numbers.RemoveRange(left, lenght);
                    i = 0;
                }
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
