using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            var string1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            var string2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            CheckStrings(string1 , string2);

            
        }
        public static void CheckStrings(char[] string1, char[] string2)
        {
            bool string1First = true;
            if (string1.Length < string2.Length || string1.Length == string2.Length)
            {
                for (int i = 0; i < string1.Length; i++)
                {
                    if (string1[i] < string2[i])
                    {
                        string1First = true;
                        break;
                    }
                    else if (string1[i] > string2[i])
                    {
                        string1First = false;
                        break;
                    }
                    else
                    {
                    }
                }
                if (string1First == true)
                {
                    Console.WriteLine(string.Join("", string1));
                    Console.WriteLine(string.Join("", string2));
                }
                else
                {
                    Console.WriteLine(string.Join("", string2));
                    Console.WriteLine(string.Join("", string1));
                }
            }
            else
            {
                    Console.WriteLine(string.Join("", string2));
                    Console.WriteLine(string.Join("", string1));  
            }
         
        }
    }
}
