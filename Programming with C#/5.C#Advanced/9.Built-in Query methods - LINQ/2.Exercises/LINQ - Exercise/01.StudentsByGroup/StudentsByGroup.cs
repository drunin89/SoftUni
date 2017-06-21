using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StudentsByGroup
{
    class StudentsByGroup
    {
        public static void Main()
        {
            var students = GetStudents();
            var groupToPrint = 2;
            Console.WriteLine(string.Join(Environment.NewLine, students
                .Where(st => st.Group == groupToPrint)
                .OrderBy(st => st.FirstName)
                .Select(st => $"{st.FirstName} {st.LastName}")));
        }

        private static List<Student> GetStudents()
        {
            var students = new List<Student>();
            var input = Console.ReadLine()
                .Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "END")
            {
                if (input.Length != 3)
                {
                    input = Console.ReadLine()
                        .Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                    continue;
                }

                int group;
                var isValid = int.TryParse(input.Last(), out group);

                if (isValid)
                {
                    students.Add(new Student { FirstName = input[0], LastName = input[1], Group = group });
                }

                input = Console.ReadLine()
                    .Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            }

            return students;
        }
        public class Student
        {
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public int Group { get; set; }
        }
    }
}
