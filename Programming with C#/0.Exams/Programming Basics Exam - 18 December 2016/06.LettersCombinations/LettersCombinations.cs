using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.LettersCombinations
{
    class LettersCombinations
    {
        static void Main(string[] args)
        {
            char letter1 = char.Parse(Console.ReadLine());
            char letter2 = char.Parse(Console.ReadLine());
            char letter3 = char.Parse(Console.ReadLine());
            int counter = 0;
            for (char i = letter1; i <= letter2; i++)
            {
                for (char j = letter1; j <= letter2; j++)
                {
                    for (char c = letter1; c <= letter2; c++)
                    {
                        if (i == letter3 || j == letter3 || c == letter3)
                        {
                        }
                        else
                        {
                            Console.Write(char.ToString(i));
                            Console.Write(char.ToString(j));
                            Console.Write(char.ToString(c));
                            Console.Write(" ");
                            counter += 1;
                        }

                    }
                }
            }
            Console.Write(counter);


        }
    }
}
