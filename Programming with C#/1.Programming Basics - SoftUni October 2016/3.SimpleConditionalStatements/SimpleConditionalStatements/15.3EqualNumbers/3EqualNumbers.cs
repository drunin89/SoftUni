﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._3EqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());
            if (a == b && b == c)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}