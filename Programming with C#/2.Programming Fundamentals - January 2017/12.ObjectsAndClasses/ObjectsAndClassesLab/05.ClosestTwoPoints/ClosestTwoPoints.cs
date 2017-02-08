using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ClosestTwoPoints
{
    class ClosestTwoPoints
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var points = new List<Point>();
            for (int i = 0; i < n; i++)
            {
                var currentPoint = 
                    Console.ReadLine()
                    .Split(' ')
                    .Select(double.Parse)
                    .ToArray();

                points.Add(new Point
                {
                    X = currentPoint[0],
                    Y = currentPoint[1]

                });

            }
            var minDistanceSoFar = double.MaxValue;
            Point firstPointMin = null;
            Point secondPointMin = null;
            for (int i = 0; i < points.Count - 1; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    var firstPoint = points[i];
                    var secondPoint = points[j];
                    var currentDistance = CalculateDistance(firstPoint, secondPoint);
                    if (currentDistance<minDistanceSoFar)
                    {
                        minDistanceSoFar = currentDistance;
                        firstPointMin = firstPoint;
                        secondPointMin = secondPoint;
                    }
                }
            }
            Console.WriteLine($"{minDistanceSoFar:F3}");
            Console.WriteLine($"{firstPointMin.X}, {firstPointMin.Y}");
            Console.WriteLine($"{secondPointMin.X}, {secondPointMin.Y}");

        }
    static double CalculateDistance(Point p1, Point p2)
    {
        double deltaX = p2.X - p1.X;
        double deltaY = p2.Y - p1.Y;
        return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
    }

}
}
