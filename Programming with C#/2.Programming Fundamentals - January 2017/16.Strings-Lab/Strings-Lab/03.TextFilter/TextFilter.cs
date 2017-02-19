using System;

namespace _03.TextFilter
{
    class TextFilter
    {
        public static void Main()
        {

            string[] banWords = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries); 
            string text = Console.ReadLine();
            foreach (var banWord in banWords)
            {
                    text = text.Replace(banWord, new string('*', banWord.Length));
            }
            Console.WriteLine(text);

        }
    }
}
