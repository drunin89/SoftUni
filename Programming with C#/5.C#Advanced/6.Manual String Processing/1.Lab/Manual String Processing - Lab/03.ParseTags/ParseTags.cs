using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ParseTags
{
    class ParseTags
    {
        static void Main(string[] args)
        {
            var inputText = Console.ReadLine();
            var openTag = "<upcase>";
            var closeTag = "</upcase>";

            int startIndex = inputText.IndexOf(openTag);
            while (startIndex != -1)
            {
                int endIndex = inputText.IndexOf(closeTag);
                if (endIndex == -1)
                {
                    break;
                }

                var toBeReplaced = inputText.Substring(startIndex, endIndex + closeTag.Length - startIndex);

                var replaced = toBeReplaced.Replace(openTag, String.Empty).Replace(closeTag, String.Empty).ToUpper();

                inputText = inputText.Replace(toBeReplaced, replaced);

                startIndex = inputText.IndexOf(openTag);
            }

            Console.WriteLine(inputText);
        }
    }
}
