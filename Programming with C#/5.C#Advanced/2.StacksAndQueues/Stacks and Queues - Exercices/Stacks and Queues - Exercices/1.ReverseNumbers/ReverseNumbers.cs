using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ReverseNumbers
{
    class ReverseNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var stack = new Stack<string>();

            for (int i = 0; i < input.Length; i++)
            {
                stack.Push(input[i]);
            }

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(stack.Pop());
                if (i!=input.Length-1)
                {
                    Console.Write(" ");
                }
            }

        }
    }
}
