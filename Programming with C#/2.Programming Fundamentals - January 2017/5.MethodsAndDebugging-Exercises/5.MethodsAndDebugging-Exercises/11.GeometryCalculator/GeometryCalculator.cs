using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.GeometryCalculator
{
    class GeometryCalculator
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();
            switch (figure)
            {
                case "triangle": Console.WriteLine(GetTriangleResult(figure).ToString("0.00")); break;
                case "square": Console.WriteLine(GetSquareResult(figure).ToString("0.00")); break;
                case "rectangle": Console.WriteLine(GetRectangleResult(figure).ToString("0.00")); break;
                case "circle": Console.WriteLine(GetCircleResult(figure).ToString("0.00"));  break;
                default:
                    break;
            }
        }
        public static double GetTriangleResult(string figure)
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double result = side * height / 2;
            return result;
        }
        public static double GetSquareResult(string figure)
        {
            double side = double.Parse(Console.ReadLine());
            double result = side * side;
            return result;
        }
        public static double GetRectangleResult(string figure)
        {
            double width = double.Parse(Console.ReadLine());
            double side = double.Parse(Console.ReadLine());
            double result = width * side;
            return result;
        }
        public static double GetCircleResult(string figure)
        {
            double radius = double.Parse(Console.ReadLine());
            double result = Math.PI * radius * radius;
            return result;
        }
    }
}
