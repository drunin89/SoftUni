using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SortStudents
{
    class ortStudents
    {
        public static void Main()
        {
            var students = GetStudents();
            Console.WriteLine(string.Join(Environment.NewLine, students
                .OrderBy(st => st.LastName)
                .ThenByDescending(st => st.FirstName)
                .Select(st => $"{st.FirstName} {st.LastName}")));
        }

        private static List<Student> GetStudents()
        {
            var students = new List<Student>();
            var input = Console.ReadLine().Split();

            while (input[0] != "END")
            {
                if (input.Length == 2)
                {
                    students.Add(new Student
                    {
                        FirstName = input[0],
                        LastName = input[1]
                    });
                }
                else
                {
                    throw new NotImplementedException();
                }

                input = Console.ReadLine().Split();
            }

            return students;
        }
        public class Student
        {
            public string FirstName { get; set; }

            public string LastName { get; set; }
        }
    }
}
