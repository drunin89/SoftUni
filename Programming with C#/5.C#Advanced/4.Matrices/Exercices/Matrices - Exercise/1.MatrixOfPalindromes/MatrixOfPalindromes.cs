using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.MatrixOfPalindromes
{
    class MatrixOfPalindromes
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = input[0];
            int m = input[1];
            int[,] arrayMatrix = new int[n, m];
            char firstLetter = 'a';
            for (char i = 'a'; i <= firstLetter + n - 1; i++)
            {
                for (char j = i; j < i + m; j++)
                {
                    string letters = i.ToString() + j.ToString() + i.ToString();
                    Console.Write("{0} ", letters);
                }
                Console.WriteLine();
            }

        }
    }
}
