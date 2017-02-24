using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class CubicMessages
{
    static void Main()
    {
        string encryptedMessage = Console.ReadLine();

        while (!encryptedMessage.Equals("Over!"))
        {
            int count = int.Parse(Console.ReadLine());
            var pattern = new Regex(@"^([0-9]+)([a-zA-Z]{" + count + @"})([^a-zA-Z]*)$");

            var match = pattern.Match(encryptedMessage);

            if (match.Success)
            {
                var message = match.Groups[2].ToString();
                Console.Write(message + " == ");
                var indexes = GetIndexes(match);

                foreach (var i in indexes)
                {
                    if (0 <= i && i < message.Length)
                    {
                        Console.Write(message[i]);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }

            encryptedMessage = Console.ReadLine();
        }

    }

    private static List<int> GetIndexes(Match match)
    {
        var indexes = new List<int>();
        string left = match.Groups[1].ToString();
        for (int i = 0; i < left.Length; i++)
        {
            if (Char.IsDigit(left[i]))
            {
                indexes.Add(int.Parse(left[i].ToString()));
            }
        }

        string right = match.Groups[3].ToString();
        for (int i = 0; i < right.Length; i++)
        {
            if (Char.IsDigit(right[i]))
            {
                indexes.Add(int.Parse(right[i].ToString()));
            }
        }

        return indexes;
    }
}
