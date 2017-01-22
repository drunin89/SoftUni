using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriplesofLetters
{
    class TriplesOfLetters
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 97; i < (97+n); i++)
            {
                for (int j = 97; j < (97+n); j++)
                {
                    for (int c = 97; c < (97+n); c++)
                    {
                        Console.Write((char)(i));
                        Console.Write((char)(j));
                        Console.Write((char)(c));
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
