using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.WordCount
{
    class WordCount
    {
        public static void Main()
        {
            string[] words = File.ReadAllText("words.txt").ToLower().Split();
            string[] text = File.ReadAllText("text.txt").ToLower()
                     .Split(new char[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' }, StringSplitOptions.RemoveEmptyEntries);
            var wordCount = new Dictionary<string, int>();

            foreach (string word in words)
            {
                wordCount[word] = 0;
            }

            foreach (string word in text)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                    
            }

            var sortedResult = wordCount.OrderByDescending(kvp => kvp.Value).Select(kvp => $"{kvp.Key} - {kvp.Value}").ToArray();
            File.WriteAllLines("result.txt", sortedResult);

        }
    }
}
