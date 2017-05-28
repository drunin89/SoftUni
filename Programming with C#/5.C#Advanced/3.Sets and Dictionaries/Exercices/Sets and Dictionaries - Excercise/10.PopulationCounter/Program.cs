using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Trim();
            var populationReport = new SortedDictionary<string, SortedDictionary<string, double>>();
            while (line != "report")
            {
                string[] input = line.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                var country = input[1];
                var city = input[0];
                double population = double.Parse(input[2]);
                if (!populationReport.ContainsKey(country))
                {
                    populationReport.Add(country, new SortedDictionary<string, double>());

                }
                if (!populationReport[country].ContainsKey(city))
                {
                    populationReport[country].Add(city, population);
                }
                else
                {
                    populationReport[country][city] += population;
                }
                line = Console.ReadLine().Trim();

            }
            var orderedCountries = populationReport.OrderByDescending(c => c.Value.Values.Sum());

            foreach (var country in orderedCountries)
            {
                var orderedCities = country.Value.OrderByDescending(c => c.Value);
                Console.WriteLine("{0} (total population: {1})", country.Key, country.Value.Sum(c => c.Value));
                foreach (var city in orderedCities)
                {
                    Console.WriteLine("=>" + city.Key + ": " + city.Value);
                }
            }

        }
    }
}
