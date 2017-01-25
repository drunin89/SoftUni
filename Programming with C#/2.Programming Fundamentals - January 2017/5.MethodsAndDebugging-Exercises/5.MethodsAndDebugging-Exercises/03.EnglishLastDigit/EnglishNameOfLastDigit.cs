using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EnglishLastDigit
{
    class EnglishNameOfLastDigit
    {
        static void Main(string[] args)
        {
            long n = Math.Abs(long.Parse(Console.ReadLine()));
            GetLastDigitLikeText(n);
        }
        public static void GetLastDigitLikeText(long n)
        {
            long lastDigit = n % 10;
            for (long i = 0; i <= 9; i++)
            {
                if (i==lastDigit)
                {
                    var text = new string[] {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
                    string result = Convert.ToString(text[i]);
                    Console.WriteLine(result);
                }
                
            }
           
        }
    }
}
