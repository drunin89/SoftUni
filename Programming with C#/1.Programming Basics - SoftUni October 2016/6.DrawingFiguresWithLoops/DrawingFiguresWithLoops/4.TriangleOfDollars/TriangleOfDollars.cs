﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.TriangleOfDollars
{
    class TriangleOfDollars
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (var row = 1; row <= n; row++)
            {
                Console.Write("$");
                for (var col = 1; col < row; col++)
                    Console.Write(" $");
                Console.WriteLine();
            }
        }
    }
}
