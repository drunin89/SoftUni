﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanVariable
{
    class BooleanVariable
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            if (text == "True")
            {
                Console.WriteLine("Yes");
            }
            else
                Console.WriteLine("No");
        }
    }
}
