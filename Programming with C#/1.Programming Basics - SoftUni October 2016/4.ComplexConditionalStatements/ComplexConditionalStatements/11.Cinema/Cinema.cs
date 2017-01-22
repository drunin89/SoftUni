using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine().ToLower();
            var r = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());
            switch (type)
            {
                case "premiere": Console.WriteLine("{0:f2}", r * c * 12); break;
                case "normal": Console.WriteLine("{0:f2}", r * c * 7.5); break;
                case "discount": Console.WriteLine("{0:f2}", r * c * 5); break;
                default:
                    break;
            }
        }
    }
}
