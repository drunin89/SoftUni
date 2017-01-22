using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.RectangleOfNxNStars
{
    class RectangleOfNxNStars
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (var i = 1; i <= n; i++)
            {
                Console.Write("*");
                for (var c = 1; c < n; c++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
