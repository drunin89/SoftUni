﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SortEvenNumbers
{
    class SortEvenNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(", ", Console.ReadLine()
                 .Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(n => int.Parse(n))
                 .Where(n => n % 2 == 0)
                 .OrderBy(n => n)
                 .ToList())); 
             

        }
    }
}
