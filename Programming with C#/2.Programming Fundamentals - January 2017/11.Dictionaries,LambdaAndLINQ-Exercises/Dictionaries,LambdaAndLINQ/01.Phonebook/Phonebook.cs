﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Phonebook
{
    class Phonebook
    {
        public static void Main(string[] args)
        {

            var phonebook = new SortedDictionary<string, string>();

            bool canContinue = true;

            while (canContinue)
            {
                string[] command = Console.ReadLine().Split();

                switch (command[0])
                {
                    case "A":
                        AddToPB(phonebook, command);
                        break;
                    case "S":
                        SearchPB(phonebook, command);
                        break;
                    case "END":
                        canContinue = false;
                        break;
                }
            }
        }

        private static void SearchPB(SortedDictionary<string, string> phonebook, string[] command)
        {
            if (phonebook.ContainsKey(command[1]))
            {
                Console.WriteLine("{0} -> {1}", command[1], phonebook[command[1]]);
            }
            else
            {
                Console.WriteLine($"Contact {command[1]} does not exist.");
            }
        }

        private static void AddToPB(SortedDictionary<string, string> phonebook, string[] command)
        {

            if (phonebook.ContainsKey(command[1]))
            {
                phonebook[command[1]] = command[2];
            }
            else
            {
                phonebook.Add(command[1], command[2]);
            }
        }
    }
}