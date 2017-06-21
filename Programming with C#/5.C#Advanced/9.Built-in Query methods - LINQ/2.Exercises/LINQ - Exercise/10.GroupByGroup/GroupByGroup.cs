using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.GroupByGroup
{
    class GroupByGroup
    {
        public static void Main()
        {
            Console.WriteLine(string.Join(Environment.NewLine, GetStudents()
                .GroupBy(p => p.Group)
                .OrderBy(g => g.Key)
                .Select(g => $"{g.Key} - {string.Join(", ", g.Select(p => p.Name))}")));
        }

        private static List<Person> GetStudents()
        {
            var students = new List<Person>();
            var input = Console.ReadLine();

            while (input != "END")
            {
                var indexOfLastSpace = input.LastIndexOf(' ');

                if (indexOfLastSpace > 0)
                {
                    students.Add(new Person
                    {
                        Name = input.Substring(0, indexOfLastSpace),
                        Group = int.Parse(input.Substring(indexOfLastSpace + 1))
                    });
                }

                input = Console.ReadLine();
            }

            return students;
        }
        public class Person
        {
            public string Name { get; set; }

            public int Group { get; set; }
        }
    }
}
