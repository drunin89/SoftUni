using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _01.SoftuniCoffeeOrders
{
    class SoftuniCoffeeOrders
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var totalPrice = 0m;
            for (int i = 0; i < n; i++)
            {
                var pricePerCapsule = decimal.Parse(Console.ReadLine());
                var orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                long capsuleCount = long.Parse(Console.ReadLine());
                var daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);

                var currentPrice = ((daysInMonth * capsuleCount) * pricePerCapsule);
                totalPrice += currentPrice;
                Console.WriteLine($"The price for the coffee is: ${currentPrice:F2}");


            }

            Console.WriteLine($"Total: ${totalPrice:F2}");


        }
    }
}
