using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.AreaOfFigures
{
    class AreaOfFigures
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double a = 0;
            double b = 0;
            double result = 0;
            if (figure == "square")
            {
                a = double.Parse(Console.ReadLine());
                result = Math.Pow(a, 2);
            }
            else if (figure == "rectangle")
            {
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                result = a * b;

            }
            else if (figure == "circle")
            {
                a = double.Parse(Console.ReadLine());
                result = Math.PI * Math.Pow(a, 2);
            }
            else if (figure == "triangle")
            {
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                result = (a * b) / 2;
            }
            else
            {
                Console.WriteLine("Greshka");
            }
            Console.WriteLine(Math.Round(result, 3));
        }
    }
}
