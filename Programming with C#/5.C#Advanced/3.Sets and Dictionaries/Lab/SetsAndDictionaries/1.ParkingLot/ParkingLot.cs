using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ParkingLot
{
    class ParkingLot
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var parking = new SortedSet<string>();

            while (input != "END")
            {
                var inputParams = input.Split(new char[] {','}, StringSplitOptions.RemoveEmptyEntries);
                if (inputParams[0] == "IN")
                {
                    parking.Add(inputParams[1]);
                }
                else
                {
                    if (parking.Contains(inputParams[1]))
                    {
                        parking.Remove(inputParams[1]);
                    }
                }

                input = Console.ReadLine();
            }
            if (parking.Count != 0)
            {
                foreach (var car in parking)
                {
                    Console.WriteLine(car.Trim());
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty"); 
            }
  
        }
    }
}
