using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ladybugs
{
    class Ladybugs
    {
        public static void Main()
        {
            var fieldSize = int.Parse(Console.ReadLine());
            var ladyBugIndexes = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .Where(a => a >= 0 && a < fieldSize)
                .ToArray();

            var ladyBugs = new int[fieldSize];
            for (int i = 0; i < ladyBugIndexes.Length; i++)
            {
                var currentLadyBugIndex = ladyBugIndexes[i];
                ladyBugs[currentLadyBugIndex] = 1;
            }
            var line = Console.ReadLine();
            while (line != "end")
            {
                var tokens = line.Split();
                var ladyBugIndex = int.Parse(tokens[0]);
                var direction = tokens[1];
                var flyLength = int.Parse(tokens[2]);
                if (ladyBugIndex < 0 || ladyBugIndex >= ladyBugs.Length)
                {
                    line = Console.ReadLine();
                    continue;
                }
                if (ladyBugs[ladyBugIndex] == 0)
                {
                    line = Console.ReadLine();
                    continue;
                }

                MoveLadyBug(ladyBugs, ladyBugIndex, flyLength, direction);

                line = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", ladyBugs));

        }

        private static void MoveLadyBug(int[] ladyBugs, int ladyBugIndex, int flyLength, string direction)
        {
            ladyBugs[ladyBugIndex] = 0;
            var leftArrayOrFoundPlace = false;
            while (!leftArrayOrFoundPlace)
            {
                switch (direction)
                {
                    case "left": ladyBugIndex -= flyLength; break;
                    case "right": ladyBugIndex += flyLength; break;
                }
                if (ladyBugIndex <0 || ladyBugIndex >= ladyBugs.Length)
                {
                    leftArrayOrFoundPlace = true;
                    continue;
                }
                if (ladyBugs[ladyBugIndex] == 1)
                {
                    continue;
                }
                if (ladyBugs[ladyBugIndex] == 0)
                {
                    ladyBugs[ladyBugIndex] = 1;
                    leftArrayOrFoundPlace = true;
                    continue;
                }
            }
        }
    }
}
