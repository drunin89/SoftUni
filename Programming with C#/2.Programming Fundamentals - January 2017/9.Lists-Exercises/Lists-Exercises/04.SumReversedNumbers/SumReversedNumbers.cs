﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SumReversedNumbers
{
    class SumReversedNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Console.ReadLine().Split().Select(a => int.Parse(new string(a.Reverse().ToArray()))).Sum());
        }
    }
}
