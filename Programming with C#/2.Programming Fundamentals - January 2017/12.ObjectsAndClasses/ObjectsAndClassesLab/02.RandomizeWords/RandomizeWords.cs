using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RandomizeWords
{
    class RandomizeWords
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');
            Random rnd = new Random();

            for (int pos1 = 0; pos1 < words.Length; pos1++)
            {
                var currentWord = words[pos1];
                var pos2 = rnd.Next(words.Length);
                var tempWords = words[pos2];
                words[pos1] = tempWords;
                words[pos2] = currentWord;

            }
            Console.WriteLine(string.Join("\r\n", words));
            
        }
    }
}
