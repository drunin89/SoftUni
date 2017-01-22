using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SmallShop
{
    class SmallShop
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine().ToLower();
            var town = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());
            if (town == "sofia")
            {
                switch (product)
                {
                    case "coffee": Console.WriteLine(quantity * 0.50); break;
                    case "water": Console.WriteLine(quantity * 0.80); break;
                    case "beer": Console.WriteLine(quantity * 1.20); break;
                    case "sweets": Console.WriteLine(quantity * 1.45); break;
                    case "peanuts": Console.WriteLine(quantity * 1.60); break;
                    default:
                        ;
                        break;
                }
            }
            else if (town == "plovdiv")
            {
                switch (product)
                {
                    case "coffee": Console.WriteLine(quantity * 0.40); break;
                    case "water": Console.WriteLine(quantity * 0.70); break;
                    case "beer": Console.WriteLine(quantity * 1.15); break;
                    case "sweets": Console.WriteLine(quantity * 1.30); break;
                    case "peanuts": Console.WriteLine(quantity * 1.50); break;
                    default:
                        ;
                        break;
                }
            }
            else if (town == "varna")
            {
                switch (product)
                {
                    case "coffee": Console.WriteLine(quantity * 0.45); break;
                    case "water": Console.WriteLine(quantity * 0.70); break;
                    case "beer": Console.WriteLine(quantity * 1.10); break;
                    case "sweets": Console.WriteLine(quantity * 1.35); break;
                    case "peanuts": Console.WriteLine(quantity * 1.55); break;
                    default:
                        ;
                        break;
                }
            }
            else
            {
            }

        }
    }
}
