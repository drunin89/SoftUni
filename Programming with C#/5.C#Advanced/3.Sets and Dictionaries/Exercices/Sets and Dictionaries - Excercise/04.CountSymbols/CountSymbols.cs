﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CountSymbols
{
    class CountSymbols
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var counts = new SortedDictionary<char, int>();

            foreach (char ch in text)
            {
                if (counts.ContainsKey(ch))
                {
                    counts[ch]++;
                }
                else
                {
                    counts[ch] = 1;
                }
                
            }
            foreach (var pair in counts)
            {
                Console.WriteLine("{0}: {1} time/s", pair.Key, pair.Value);
            }
            
        }
    }
}
