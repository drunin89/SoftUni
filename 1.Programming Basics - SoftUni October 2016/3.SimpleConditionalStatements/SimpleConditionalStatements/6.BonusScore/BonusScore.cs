using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            double bonus = 0;
            if (num <= 100)
            {
                bonus = 5;

            }
            else if (num > 100 && num < 1000)
            {
                bonus = num * 0.2;
            }
            else
            {
                bonus = num * 0.1;
            }

            if (num % 2 == 0)
            {
                bonus = bonus + 1;

            }
            else if (num % 10 == 5)
            {
                bonus = bonus + 2;

            }
            else
            {

            }
            Console.WriteLine(bonus);
            Console.WriteLine(bonus + num);

        }
    }
}
