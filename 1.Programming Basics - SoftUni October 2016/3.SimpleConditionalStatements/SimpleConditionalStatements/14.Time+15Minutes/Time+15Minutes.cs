using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Time_15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int min15 = min + 15;
            if (min15 > 59)
            {
                hour += 1;
                min15 -= 60;
            }
            else
            {
            }
            if (hour == 24)
            {
                hour = 0;
            }
            else
            {
            }
            Console.WriteLine("{0}:{1}", hour.ToString("0"), min15.ToString("00"));


        }
    }
}
