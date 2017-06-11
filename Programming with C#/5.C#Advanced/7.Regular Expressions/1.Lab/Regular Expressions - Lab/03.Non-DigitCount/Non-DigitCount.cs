﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Non_DigitCount
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Regex regex = new Regex("[\\D]");
            MatchCollection matches = regex.Matches(input);

            Console.WriteLine($"Non-digits: {matches.Count}");

        }
    }
}
