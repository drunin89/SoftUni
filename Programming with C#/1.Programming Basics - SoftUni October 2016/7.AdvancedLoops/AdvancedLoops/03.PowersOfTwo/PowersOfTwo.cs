using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PowersOfTwo
{
    class PowersOfTwo
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("1");
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(Math.Pow(2, i));
            }

        }
    }
}
