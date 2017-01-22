using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.RadiansToDegrees
{
    class RadiansToDegrees
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = (a * 180) / Math.PI;
            Console.WriteLine(Math.Round(b));
        }
    }
}
