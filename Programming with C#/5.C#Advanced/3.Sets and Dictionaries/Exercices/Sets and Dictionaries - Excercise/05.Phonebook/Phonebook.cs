using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            var contactBook = new Dictionary<string, string>();
            var line = Console.ReadLine();

            while (line != "search")
            {
                var inputData = line.Split('-').ToArray();
                var contactName = inputData[0];
                var contactPhone = inputData[1];

                if (!contactBook.ContainsKey(contactName))
                {
                    contactBook.Add(contactName, contactPhone);
                }
                else
                {
                    contactBook[contactName] = contactPhone;
                }

                line = Console.ReadLine();
            }

            var line2 = Console.ReadLine();
            while (line2 != "stop")
            {
                if (!contactBook.ContainsKey(line2))
                {
                    Console.WriteLine($"Contact {line2} does not exist.");
                }
                else
                {
                    Console.WriteLine($"{line2} -> {contactBook[line2]}");
                }
                line2 = Console.ReadLine();
            }

        }
    }
}
