﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MelrahShake
{
    class MelrahShake
    {
        public static void Main()
        {
            string input = Console.ReadLine().Trim();
            string pattern = Console.ReadLine();

            bool canShake = true;

            while (canShake)
            {
                int indxFirst = input.IndexOf(pattern);
                int indxLast = input.LastIndexOf(pattern);
                if (indxFirst > -1 && indxLast > -1 && pattern.Length > 0)
                {
                    indxFirst = input.IndexOf(pattern);
                    input = input.Remove(indxFirst, pattern.Length);
                    indxLast = input.LastIndexOf(pattern);
                    input = input.Remove(indxLast, pattern.Length);
                    Console.WriteLine("Shaked it.");
                    if (pattern.Length > 0)
                    {
                        pattern = pattern.Remove(pattern.Length / 2, 1);
                    }

                }
                else
                {
                    Console.WriteLine("No shake.");
                    canShake = false;
                    Console.WriteLine(input);
                    break;
                }
            }
        }
    }
}
