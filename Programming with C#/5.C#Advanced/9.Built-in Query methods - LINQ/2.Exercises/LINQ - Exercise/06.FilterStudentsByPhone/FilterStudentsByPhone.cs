using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FilterStudentsByPhone
{
    class FilterStudentsByPhone
    {
        public static void Main()
        {
            var students = GetStudents();
            Console.WriteLine(string.Join(Environment.NewLine, students
                .Where(kvp => kvp.Value.StartsWith("02") || kvp.Value.StartsWith("+3592"))
                .Select(kvp => kvp.Key)));

        }

        private static List<KeyValuePair<string, string>> GetStudents()
        {
            var students = new List<KeyValuePair<string, string>>();
            var input = Console.ReadLine();

            while (input != "END")
            {
                var indexOfLastSpace = input.LastIndexOf(' ');

                if (indexOfLastSpace > 1)
                {
                    var phone = input.Substring(indexOfLastSpace + 1);
                    var name = input.Substring(0, indexOfLastSpace);
                    students.Add(new KeyValuePair<string, string>(name, phone));
                }

                input = Console.ReadLine();
            }

            return students;
        }
    }
}
