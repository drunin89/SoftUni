using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.SumSeconds
{
    class SumSeconds
    {
        static void Main(string[] args)
        {
            var firstSec = double.Parse(Console.ReadLine());
            var secondSec = double.Parse(Console.ReadLine());
            var thirdSec = double.Parse(Console.ReadLine());
            var total = firstSec + secondSec + thirdSec;
            var sec = (total % 60).ToString("00");
            int min = (int)total / 60;
            Console.WriteLine("{0}:{1}", min, sec);


        }
    }
}
