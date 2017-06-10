using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FormattingNumbers
{
    class FormattingNumbers
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { '\n', '\r', '\t', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int a = int.Parse(input[0]);
            double b = double.Parse(input[1]);
            double c = double.Parse(input[2]);

            string firstColInHex = $"|{a.ToString("X"),-10}";
            string secondColBinary = $"|{Convert.ToString(a, 2).PadLeft(10, '0').Substring(0, 10)}|";
            string thirdCol = $"{b,10:F2}|";
            string fourthCol = $"{c,-10:F3}|";

            Console.WriteLine($"{firstColInHex}{secondColBinary}{thirdCol}{fourthCol}");
        }
    }
}
