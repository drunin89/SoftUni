using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.MetricConverter
{
    class MetricConverter
    {
        static void Main(string[] args)
        {
            var amount = double.Parse(Console.ReadLine());
            string firstMetric = Console.ReadLine();
            string secondMetric = Console.ReadLine();

            var currencies = new Dictionary<string, double>()
            {

                {"m", 1 },
                {"mm", 1000},
                {"cm", 100},
                {"mi", 0.000621371192},
                {"in", 39.3700787},
                {"km", 0.001},
                {"ft", 3.2808399},
                {"yd", 1.0936133},

            };

            double result = (currencies[secondMetric] / currencies[firstMetric]) * amount;

            Console.WriteLine("{0} {1}", result, secondMetric);

        }
    }
}
