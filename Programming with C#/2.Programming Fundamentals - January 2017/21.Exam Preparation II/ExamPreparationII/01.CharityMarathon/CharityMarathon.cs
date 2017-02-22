using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CharityMarathon
{
    class CharityMarathon
    {
        public static void Main()
        {
            var maratonDays = decimal.Parse(Console.ReadLine());
            var numberOfRunners = decimal.Parse(Console.ReadLine());
            var numberOfLaps = decimal.Parse(Console.ReadLine());
            var trackLenght = decimal.Parse(Console.ReadLine());
            var trackCapacity = decimal.Parse(Console.ReadLine());
            var moneyPerKilometer = decimal.Parse(Console.ReadLine());
            var totalRunners = Math.Min(numberOfRunners, trackCapacity * maratonDays);
            var totalMeters = totalRunners * numberOfLaps * trackLenght;
            var totalKilometers = totalMeters / 1000;
            var moneyRaised = totalKilometers * moneyPerKilometer;
            Console.WriteLine($"Money raised: {moneyRaised:F2}");



        }
    }
}
