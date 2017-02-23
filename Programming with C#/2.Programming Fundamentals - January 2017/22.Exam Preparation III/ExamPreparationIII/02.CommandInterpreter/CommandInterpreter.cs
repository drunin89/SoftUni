using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.CommandInterpreter
{
    class CommandInterpreter
    {
        public static void Main()
        {

            var array = Console.ReadLine()
                .Trim()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var inputLine = Console.ReadLine();
            while (inputLine!="end")
            {
                var commandParams = inputLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var instruction = commandParams[0];
                switch (instruction)
                {
                    case "reverse":
                        int reverseStart = int.Parse(commandParams[2]);
                        int reverseCount = int.Parse(commandParams[4]);
                        if (IsValid(array, reverseStart, reverseCount))
                        {
                            array.Reverse(reverseStart, reverseCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;
                    case "sort":
                        int sortStart = int.Parse(commandParams[2]);
                        int sortCount = int.Parse(commandParams[4]);
                        if (IsValid(array, sortStart, sortCount))
                        {
                            Sort(array, sortStart, sortCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;
                    case "rollLeft":
                        int rollLeftCount = int.Parse(commandParams[1]);
                        
                        if (rollLeftCount >=0)
                        {
                            RollLeft(array, rollLeftCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;
                    case "rollRight":
                        int rollRightCount = int.Parse(commandParams[1]);
                        
                        if (rollRightCount>=0)
                        {
                            RollRight(array, rollRightCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;

                }
                

                inputLine = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", array)}]");
        }

        private static void Sort(List<string> array, int sortStart, int sortCount)
        {
            var resultArray = array.Skip(sortStart).Take(sortCount).OrderBy(x => x).ToList();
            array.RemoveRange(sortStart, sortCount);
            array.InsertRange(sortStart, resultArray);
        }

        private static void Reverse(List<string> array, int reverseStart, int reverseCount)
        {
            var resultArray = array.Skip(reverseStart).Take(reverseCount).Reverse().ToList();
            array.RemoveRange(reverseStart, reverseCount);
            array.InsertRange(reverseStart, resultArray);
        }

        private static void RollRight(List<string> array, int rollRightCount)
        {
            rollRightCount = rollRightCount % array.Count;
            for (int i = 0; i < rollRightCount; i++)
            {
                var lastElem = array[array.Count - 1];
                array.RemoveAt(array.Count - 1);
                array.Insert(0, lastElem);
            }
        }

        private static void RollLeft(List<string> array, int rollLeftCount)
        {
            rollLeftCount = rollLeftCount % array.Count;
            for (int i = 0; i < rollLeftCount; i++)
            {
                var FirstLine = array[0];
                for (int j = 0; j < array.Count - 1; j++)
                {
                    array[j] = array[j + 1];
                }
                array[array.Count - 1] = FirstLine;
            }
        }

        private static bool IsValid(List<string> array, int start, int count)
        {
            if (start>= 0 && start< array.Count && count>= 0 && (start+count)<=array.Count)
            {
                return true;
            }
            return false;
        }
    }
}
