using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.USDToBGN
{
    class USDToBGN
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = (a * 1.79549);
            Console.WriteLine(Math.Round(b, 2));
        }
    }
}
