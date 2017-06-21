﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MapDistricts
{
    class MapDistricts
    {
        static void Main(string[] args)
        {
            var townsPopulation = GetTownsPopulation();
            var minBorder = long.Parse(Console.ReadLine());
            var sums = townsPopulation.ToDictionary(x => x.Key, x => x.Value.Sum());

            Console.WriteLine(string.Join(Environment.NewLine, townsPopulation
                .Where(kvp => sums[kvp.Key] >= minBorder)
                .OrderByDescending(kvp => sums[kvp.Key])
                .Select(t => $"{t.Key}: {string.Join(" ", t.Value.OrderByDescending(n => n).Take(5))}")));
        }

        private static Dictionary<string, List<long>> GetTownsPopulation()
        {
            var districtsPopulation = Console.ReadLine().Split();
            var townsPopulation = new Dictionary<string, List<long>>();

            foreach (var district in districtsPopulation)
            {
                var indexOfSeparation = district.IndexOf(':');

                if (indexOfSeparation < 0)
                {
                    continue;
                }

                var town = district.Substring(0, indexOfSeparation);
                var currentPopulation = int.Parse(district.Substring(indexOfSeparation + 1));

                if (!townsPopulation.ContainsKey(town))
                {
                    townsPopulation[town] = new List<long>();
                }

                townsPopulation[town].Add(currentPopulation);
            }

            return townsPopulation;
        }
    }
}
