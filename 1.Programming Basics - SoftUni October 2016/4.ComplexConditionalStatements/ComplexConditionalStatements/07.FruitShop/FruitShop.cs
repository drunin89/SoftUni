using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.FruitShop
{
    class FruitShop
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine().ToLower();
            var day = Console.ReadLine().ToLower();
            var qty = double.Parse(Console.ReadLine());
            if (day == "saturday" || day == "sunday")
            {
                switch (fruit)
                {
                    case "banana": Console.WriteLine(qty * 2.7); break;
                    case "apple": Console.WriteLine(qty * 1.25); break;
                    case "orange": Console.WriteLine(qty * 0.9); break;
                    case "grapefruit": Console.WriteLine(qty * 1.6); break;
                    case "kiwi": Console.WriteLine(qty * 3); break;
                    case "pineapple": Console.WriteLine(qty * 5.6); break;
                    case "grapes": Console.WriteLine(qty * 4.2); break;
                    default:
                        Console.WriteLine("error");
                        break;

                }

            }
            else if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
            {
                switch (fruit)
                {
                    case "banana": Console.WriteLine(qty * 2.5); break;
                    case "apple": Console.WriteLine(qty * 1.20); break;
                    case "orange": Console.WriteLine(qty * 0.85); break;
                    case "grapefruit": Console.WriteLine(qty * 1.45); break;
                    case "kiwi": Console.WriteLine(qty * 2.7); break;
                    case "pineapple": Console.WriteLine(qty * 5.5); break;
                    case "grapes": Console.WriteLine(qty * 3.85); break;
                    default:
                        Console.WriteLine("error");
                        break;

                }
            }
            else
            {
                Console.WriteLine("error");
            }

        }
    }
}
