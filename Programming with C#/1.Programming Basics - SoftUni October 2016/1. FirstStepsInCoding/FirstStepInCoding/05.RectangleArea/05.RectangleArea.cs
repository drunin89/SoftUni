using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = decimal.Parse(Console.ReadLine());
            var b = decimal.Parse(Console.ReadLine());
            var s = (a * b);
            Console.WriteLine("The are of triangle is:");
            Console.WriteLine(s);
        }
    }
}
