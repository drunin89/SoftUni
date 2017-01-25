using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Hello_Name_
{
    class HelloName
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            GetSentence(text);

        }
        public static void GetSentence(string text)
        {
            Console.WriteLine($"Hello, {text}!");
        }
    }
}
