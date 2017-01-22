using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ChristmasHat
{
    class ChristmasHat
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var a = "*";
            var b = ".";
            Console.WriteLine(new string('.', 2 * n - 1) + @"/|\" + new string('.', 2 * n - 1));
            Console.WriteLine(new string('.', 2 * n - 1) + @"\|/" + new string('.', 2 * n - 1));

            for (int i = 0; i < 2 * n; i++)
            {
                Console.WriteLine(new string('.', 2 * n - 1 - i) + "*" + new string('-', i) + "*" + new string('-', i) + "*" + new string('.', 2 * n - 1 - i));
            }



            Console.WriteLine(new string('*', 4 * n + 1));
            for (int i = 1; i <= 2 * n; i++)
            {
                Console.Write(a);
                Console.Write(b);
            }
            Console.Write("*");
            Console.WriteLine();
            Console.WriteLine(new string('*', 4 * n + 1));
        }
    }
}
