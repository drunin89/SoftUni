using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.AverageOfDoubles
{
    class AverageOfDoubles
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(double.Parse);
            Console.WriteLine($"{numbers.Average():F2}");
        }
    }
}
