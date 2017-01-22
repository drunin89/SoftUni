using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Diamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            if (n > 1)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine(new string('-', (n - 2) / 2) + new string('*', 2) + new string('-', (n - 2) / 2));
                    for (int i = 1; i < n / 2; i++)
                    {

                        Console.WriteLine(new string('-', (n - 2) / 2 - i) + new string('*', 1) + new string('-', i * 2) + new string('*', 1) + new string('-', (n - 2) / 2 - i));
                    }
                    for (int i = 1; i < n / 2; i++)
                    {
                        Console.WriteLine(new string('-', i) + new string('*', 1) + new string('-', n - 2 - i * 2) + new string('*', 1) + new string('-', i));
                    }

                }
                else
                {
                    Console.WriteLine(new string('-', (n - 1) / 2) + new string('*', 1) + new string('-', (n - 1) / 2));
                    Console.WriteLine(new string('-', (n - 1) / 2 - 1) + new string('*', 1) + new string('-', 1) + new string('*', 1) + new string('-', (n - 1) / 2 - 1));
                    for (int i = 1; i < n / 2; i++)
                    {

                        Console.WriteLine(new string('-', (n - 2) / 2 - i) + new string('*', 1) + new string('-', i * 2 + 1) + new string('*', 1) + new string('-', (n - 2) / 2 - i));
                    }

                    for (int i = 1; i < n / 2; i++)
                    {
                        Console.WriteLine(new string('-', i) + new string('*', 1) + new string('-', n - 2 - i * 2) + new string('*', 1) + new string('-', i));
                    }
                    Console.WriteLine(new string('-', (n - 1) / 2) + new string('*', 1) + new string('-', (n - 1) / 2));


                }
            }
            else if (n == 1)
            {
                Console.WriteLine("*");
            }
            else
            {
            }

        }
    }
}
