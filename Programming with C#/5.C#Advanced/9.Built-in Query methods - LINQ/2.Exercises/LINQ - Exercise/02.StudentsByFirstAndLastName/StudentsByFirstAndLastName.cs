﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StudentsByFirstAndLastName
{
    class StudentsByFirstAndLastName
    {
        public static void Main()
        {
            var students = GetStudents();
            Console.WriteLine(string.Join(Environment.NewLine, students
                .Where(st => st.Key.CompareTo(st.Value) < 0)
                .Select(st => $"{st.Key} {st.Value}")));
        }

        private static List<KeyValuePair<string, string>> GetStudents()
        {
            var students = new List<KeyValuePair<string, string>>();
            var input = Console.ReadLine()
                .Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "END")
            {
                if (input.Length == 2)
                {
                    students.Add(new KeyValuePair<string, string>(input[0], input[1]));
                }

                input = Console.ReadLine()
                    .Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            }

            return students;
        }
    }
}
