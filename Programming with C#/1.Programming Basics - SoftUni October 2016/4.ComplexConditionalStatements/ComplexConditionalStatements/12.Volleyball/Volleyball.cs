using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Volleyball
{
    class Volleyball
    {
        static void Main(string[] args)
        {
            var godina = Console.ReadLine().ToLower();
            var p = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var sofia = 48 - h;
            var igriSofia = sofia * 3.0 / 4;
            var igriPraznik = p * 2.0 / 3;
            var total = igriSofia + igriPraznik + h;
            if (godina == "normal")
            {
                Console.WriteLine(Math.Truncate(total));
            }
            else
            {
                Console.WriteLine(Math.Truncate(total * 1.15));
            }
        }
    }
}
