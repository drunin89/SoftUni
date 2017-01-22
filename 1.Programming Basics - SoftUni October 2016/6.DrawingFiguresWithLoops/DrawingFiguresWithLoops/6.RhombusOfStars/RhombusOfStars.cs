using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.RhombusOfStars
{
    class RhombusOfStars
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var hight = n * 2 - 1;
            var width = n * 2 - 1;
            //upper part
            for (int i = 1; i <= n; i++)
            {
                var line = new string(' ', n - i);

                for (int j = 1; j <= i; j++)
                {
                    line += "*";
                    line += " ";

                }
                Console.WriteLine(line);

            }
            //lower part
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(new string(' ', i + 1) + "*");
                for (int j = n - (2 + i); j > 0; j--)
                {
                    Console.Write(" ");
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
