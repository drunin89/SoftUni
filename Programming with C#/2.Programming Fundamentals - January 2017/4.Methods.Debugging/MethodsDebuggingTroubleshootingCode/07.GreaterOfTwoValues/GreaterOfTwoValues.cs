using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.GreaterOfTwoValues
{
    class GreaterOfTwoValues
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            if (type == "int")
            {
                var first = int.Parse(Console.ReadLine());
                var second = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(first, second));
            }
            else if (type == "char")
            {
                var first = char.Parse(Console.ReadLine());
                var second = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(first, second));
            }
            else
            {
                var first = Console.ReadLine();
                var second = Console.ReadLine();
                Console.WriteLine(GetMax(first, second));
            }

        }
        public static int GetMax(int first, int second)
        {
            if (first >= second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        public static char GetMax(char first, char second)
        {
            if (first.CompareTo(second) >= 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        public static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) >= 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
