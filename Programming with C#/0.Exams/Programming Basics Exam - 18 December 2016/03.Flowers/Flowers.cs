using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Flowers
{
    class Flowers
    {
        static void Main(string[] args)
        {
            int hrizantemi = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int laleta = int.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            var holiday = Console.ReadLine();
            double sumaCvetq = hrizantemi + roses + laleta;
            double amountHrizantemi = 0;
            double amountRoses = 0;
            double amountLaleta = 0;
            double result = 0;
            if (season == "Spring" || season == "Summer")
            {
                amountHrizantemi = hrizantemi * 2;
                amountRoses = roses * 4.1;
                amountLaleta = laleta * 2.5;
                result = amountHrizantemi + amountRoses + amountLaleta;

            }
            else
            {
                amountHrizantemi = hrizantemi * 3.75;
                amountRoses = roses * 4.5;
                amountLaleta = laleta * 4.15;
                result = amountHrizantemi + amountRoses + amountLaleta;

            }
            if (holiday == "Y")
            {
                result *= 1.15;

            }

            if (laleta >= 7 && season == "Spring")
            {
                result *= 0.95;

            }
            if (roses >= 10 && season == "Winter")
            {
                result = result * 0.9;

            }
            if (sumaCvetq >= 20)
            {
                result = result * 0.8;
            }

            Console.WriteLine("{0:f2}", result + 2);


        }
    }
}
