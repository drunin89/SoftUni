using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CubeProperties
{
    class CubeProperties
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            var whichCalculations = Console.ReadLine();
            switch (whichCalculations)
            {
                case "face": Console.WriteLine(GetFaceCalculations(a).ToString("0.00")); break;
                case "space": Console.WriteLine(GetSpaceCalculations(a).ToString("0.00")); break;
                case "volume": Console.WriteLine(GetVolumeCalculations(a).ToString("0.00")); break;
                case "area": Console.WriteLine(GetAreaCalculations(a).ToString("0.00")); break;
                default:
                    break;
            }
        }

        private static double GetFaceCalculations(double a)
        {
            double result = Math.Sqrt(2 * a * a);
            return result;
        }
        private static double GetSpaceCalculations(double a)
        {
            double result = Math.Sqrt(3 * a * a);
            return result;
        }
        private static double GetVolumeCalculations(double a)
        {
            double result = a * a * a;
            return result;
        }
        private static double GetAreaCalculations(double a)
        {
            double result = (6 * a * a);
            return result;
        }
    }
}
