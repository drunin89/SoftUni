using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.PointInTheFigure
{
    class PointInTheFigure
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            var insideFirstRectangle = (x > 0 && x < 3 * h) && (y > 0 && y < h);
            var insideSecondRectangle = (x > h && x < 2 * h) && (y > h && y < 4 * h);
            var onMiddleSide = (x > h && x < 2 * h && y == h);

            var outsideFirstRectangle = (x < 0 || x > 3 * h) || (y < 0 || y > h);
            var outsideSecondRectangle = (x < h || x > 2 * h) || (y < h || y > 4 * h);

            if (insideFirstRectangle || insideSecondRectangle || onMiddleSide)
            {
                Console.WriteLine("inside");
            }
            else if (outsideFirstRectangle && outsideSecondRectangle)
            {
                Console.WriteLine("outside");
            }
            else
            {
                Console.WriteLine("border");
            }
        }
    }
}
