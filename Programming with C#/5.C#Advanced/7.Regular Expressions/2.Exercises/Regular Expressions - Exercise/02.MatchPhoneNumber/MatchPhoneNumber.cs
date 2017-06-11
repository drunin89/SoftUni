using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.MatchPhoneNumber
{
    class MatchPhoneNumber
    {
        public static void Main()
        {
            var numbers = ReadInput();
            var regex = new Regex(@"^\s*\+359( |-)2\1[0-9]{3}\1[0-9]{4}\b");

            while (numbers.Count > 0)
            {
                if (regex.IsMatch(numbers.Peek()))
                {
                    Console.WriteLine(numbers.Pop());
                }
                else
                {
                    numbers.Pop();
                }
            }
        }

        private static Stack<string> ReadInput()
        {
            var stack = new Stack<string>();
            var input = Console.ReadLine();

            while (input != "end")
            {
                stack.Push(input);
                input = Console.ReadLine();
            }

            return stack;
        }
    }
}
