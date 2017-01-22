using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.House
{
    class House
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());
            var pokriv = "";
            var charti = "";
            if (n < 2)
            {
            }
            else
            {
                if (n % 2 == 0)
                {
                    charti = new string('-', (n - 2) / 2);
                    pokriv = new string('*', 2);
                    Console.WriteLine(charti + pokriv + charti);

                    for (int i = 2; i < ((n + 1) / 2) * 2; i += 2)
                    {
                        pokriv += "**";
                        Console.WriteLine(new string('-', ((n - 2) - i) / 2) + pokriv + new string('-', ((n - 2) - i) / 2));

                    }
                    for (int i = 0; i < (n + 1) / 2; i++)
                    {
                        Console.WriteLine(new string('|', 1) + new string('*', n - 2) + new string('|', 1));

                    }
                }
                else
                {
                    charti = new string('-', (n - 1) / 2);
                    pokriv = new string('*', 1);
                    Console.WriteLine(charti + pokriv + charti);

                    for (int i = 2; i < ((n + 1) / 2) * 2; i += 2)
                    {
                        pokriv += "**";
                        Console.WriteLine(new string('-', ((n - 1) - i) / 2) + pokriv + new string('-', ((n - 1) - i) / 2));

                    }
                    for (int i = 0; i < (n - 1) / 2; i++)
                    {
                        Console.WriteLine(new string('|', 1) + new string('*', n - 2) + new string('|', 1));

                    }
                }

            }
        }
    }
}
