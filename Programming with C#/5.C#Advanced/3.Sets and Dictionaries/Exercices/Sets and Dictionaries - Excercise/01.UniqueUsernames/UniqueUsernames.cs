﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.UniqueUsernames
{
    class UniqueUsernames
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var names = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine();
                names.Add(line);
            }
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
