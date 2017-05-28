﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CountSameValuesInArray
{
    class CountSameValuesInArray
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var inputTokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var dict = new SortedDictionary<double, int>();

            foreach (var token in inputTokens)
            {
                var reminder = double.Parse(token);
                
                if (!dict.ContainsKey(reminder))
                {
                    dict.Add(reminder, 1);
                }
                else
                {
                    dict[reminder]++;
                }
            }

            foreach (var pair in dict)
            {
               
                    Console.WriteLine($"{pair.Key} - {pair.Value} times");

            }


        }
    }
}
