using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.InchesToCentimeters
{
    class InchesToCentimeters
    {
        static void Main(string[] args)
        {
            var inch = double.Parse(Console.ReadLine());
            var result = inch * 2.54;
            Console.WriteLine(result);
        }
    }
}
