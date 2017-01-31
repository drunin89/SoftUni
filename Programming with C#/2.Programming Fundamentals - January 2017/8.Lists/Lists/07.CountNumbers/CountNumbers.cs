﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CountNumbers
{
    class CountNumbers
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            nums.Sort();
            var counts = new int[nums.Max() + 1];
            foreach (var num in nums)
            {
                counts[num]++;
            }

            for (int i = 0; i < counts.Length; i++)
            {
                if (counts[i] > 0)
                {
                    Console.WriteLine($"{i} -> {counts[i]}");
                }

            }


        }

    }
}

