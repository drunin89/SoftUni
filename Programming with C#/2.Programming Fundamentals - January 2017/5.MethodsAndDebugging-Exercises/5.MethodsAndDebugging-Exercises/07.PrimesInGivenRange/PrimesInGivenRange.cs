using System;
using System.Collections.Generic;

namespace _3_PrimesInGivenRange
{
    class PrimesInGivenRange
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            string numbers = String.Join(", ", CalculatePrimesInRange(startNumber, endNumber).ToArray());

            Console.WriteLine(numbers);
        }
        public static bool IsPrime(long number)
        {
            if (number == 1 || number == 0) return false;
            if (number == 2) return true;

            long half = number / 2;
            for (int i = 2; i <= half; ++i)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        private static List<int> CalculatePrimesInRange(int startNumber, int endNumber)
        {
            List<int> numbers = new List<int>();

            for (int i = startNumber; i <= endNumber; i++)
            {
                if (IsPrime(i))
                {
                    numbers.Add(i);
                }
            }

            return numbers;
        }
    }
}