﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.StudentsEnrolled
{
    class StudentsEnrolled
    {
        public static void Main()
        {
            var targetYears = new string[] { "14", "15" }; // for 2014, 2015
            Console.WriteLine(string.Join(Environment.NewLine, GetStudents()
                .Where(s => targetYears.Contains(s.Id.Substring(s.Id.Length - 2)))
                .Select(s => string.Join(" ", s.Marks))));
        }

        private static List<Student> GetStudents()
        {
            var students = new List<Student>();
            var input = Console.ReadLine()
                .Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "END")
            {
                students.Add(new Student
                {
                    Id = input[0],
                    Marks = input.Skip(1).Select(int.Parse).ToArray()
                });

                input = Console.ReadLine()
                    .Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            }

            return students;
        }
        public class Student
        {
            public string Id { get; set; }

            public int[] Marks { get; set; }
        }
    }
}
