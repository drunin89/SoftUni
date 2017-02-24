using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SweetDessert
{
    class SweetDessert
    {
        public static void Main()
        {
            var amountCash = decimal.Parse(Console.ReadLine());
            var numberGuest = int.Parse(Console.ReadLine());
            var priceBananas = decimal.Parse(Console.ReadLine());
            var priceEggs = decimal.Parse(Console.ReadLine());
            var priceBerries = decimal.Parse(Console.ReadLine());

            var portions = numberGuest / 6;
            if (numberGuest % 6 != 0)
            {
                portions++;
            }

            var pricePerPortion = 2 * priceBananas + 4 * priceEggs + 0.2m * priceBerries;
            var totalPrice = pricePerPortion * portions;

            var moneyLeft = amountCash - totalPrice;
            if (moneyLeft >= 0)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalPrice:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {Math.Abs(moneyLeft):F2}lv more.");
            }

        }
    }
}
