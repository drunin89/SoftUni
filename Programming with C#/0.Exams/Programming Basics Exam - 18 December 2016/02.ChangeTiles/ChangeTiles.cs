using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ChangeTiles
{
    class ChangeTiles
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double shirochina = double.Parse(Console.ReadLine());
            double daljina = double.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            double suma = double.Parse(Console.ReadLine());
            double plosht = shirochina * daljina;
            double plochki = a * h / 2;
            double nujniPlochki = Math.Ceiling(plosht / plochki) + 5;
            double result = nujniPlochki * price + suma;
            if (result <= money)
            {
                Console.WriteLine("{0:f2} lv left.", money - result);
            }
            else
            {
                {
                    Console.WriteLine("You'll need {0:f2} lv more.", result - money);
                }
            }


        }
    }
}
