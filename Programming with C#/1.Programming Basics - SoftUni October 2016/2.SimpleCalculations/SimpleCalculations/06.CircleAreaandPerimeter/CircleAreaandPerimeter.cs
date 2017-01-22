using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CircleAreaandPerimeter
{
    class CircleAreaandPerimeter
    {
        static void Main(string[] args)
        {
            var r = double.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(r, 2);
            double per = 2 * Math.PI * r;
            Console.WriteLine(area);
            Console.WriteLine(per);
        }
    }
}
