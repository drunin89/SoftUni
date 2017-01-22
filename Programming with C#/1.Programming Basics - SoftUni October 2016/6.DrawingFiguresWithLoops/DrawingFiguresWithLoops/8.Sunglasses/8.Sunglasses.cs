using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var firstRow = new string('*', 2 * n) + new string(' ', n) + new string('*', 2 * n);
            var middle = "";
            Console.WriteLine(firstRow);
            for (int i = 0; i < n - 2; i++)
            {
                if (i == ((n - 1) / 2 - 1))
                {
                    middle = new string('*', 1) + new string('/', 2 * n - 2) + new string('*', 1) + new string('|', n) + new string('*', 1) + new string('/', 2 * n - 2) + new string('*', 1);
                    Console.WriteLine(middle);
                }
                else
                {
                    middle = new string('*', 1) + new string('/', 2 * n - 2) + new string('*', 1) + new string(' ', n) + new string('*', 1) + new string('/', 2 * n - 2) + new string('*', 1);
                    Console.WriteLine(middle);
                }


            }


            Console.WriteLine(firstRow);

        }
    }
}
