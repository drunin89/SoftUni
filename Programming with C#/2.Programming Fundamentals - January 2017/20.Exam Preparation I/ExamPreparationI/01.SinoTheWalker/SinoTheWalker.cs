using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SinoTheWalker
{
    class SinoTheWalker
    {
        public static void Main()
        {
            var inputTime = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);
            var numbersOfSteps = int.Parse(Console.ReadLine());
            var secondsPerSteps = int.Parse(Console.ReadLine());
            ulong addingTime = (ulong)numbersOfSteps * (ulong)secondsPerSteps;
            long initialSeconds = inputTime.Hour * 60 * 60 + inputTime.Minute * 60 + inputTime.Second;
            ulong totalSeconds = (ulong)initialSeconds + (ulong)addingTime;
            
            var seconds = totalSeconds % 60;
            var totalMinutes = totalSeconds / 60;
            var minutes = totalMinutes % 60;
            var totalHours = totalMinutes / 60;
            var hours = totalHours % 24;
            Console.WriteLine($"Time Arrival: {hours:00}:{minutes:00}:{seconds:00}");


        }
    }
}
