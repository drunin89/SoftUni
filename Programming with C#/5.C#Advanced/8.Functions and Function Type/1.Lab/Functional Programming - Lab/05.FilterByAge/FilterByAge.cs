﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FilterByAge
{
    class FilterByAge
    {
        static void Main(string[] args)
        {

            var lines = int.Parse(Console.ReadLine());
            var people = new Dictionary<string, int>();

            for (int i = 0; i < lines; i++)
            {
                var input = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                people.Add(input[0], int.Parse(input[1]));
            }

            var condition = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var format = Console.ReadLine();

            Func<int, bool> tester = CreateTester(condition, age);
            Action<KeyValuePair<string, int>> printer =
                                              CreatePrinter(format);

            PrintFilteredStudent(people, tester, printer);


        }

        private static void PrintFilteredStudent(Dictionary<string, int> people, Func<int, bool> tester, Action<KeyValuePair<string, int>> printer)
        {
            foreach (var person in people)
            {
                if (tester(person.Value))
                {
                    printer(person);
                }
            }
        }

        public static Func<int, bool> CreateTester (string condition, int age)
        {
            switch (condition)
            {
                case "younger": return x => x < age;
                case "older": return x => x > age;
                default: return null;
            }
        }
        public static Action<KeyValuePair<string, int>> CreatePrinter(string format)
        {
            switch (format)
            {
            case "name":
                return person => Console.WriteLine($"{person.Key}");
            case "age":
                return person => Console.WriteLine($"{person.Value}");
            case "name age":
                return person =>
                   Console.WriteLine($"{person.Key} - {person.Value}");
            default: return null;
            }


        }
    }
}