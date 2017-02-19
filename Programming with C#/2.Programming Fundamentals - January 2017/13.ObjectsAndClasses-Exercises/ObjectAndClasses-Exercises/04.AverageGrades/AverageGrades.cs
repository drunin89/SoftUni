using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.AverageGrades
{
    class AverageGrades
    {
        public static void Main()
        {
            Students[] studentGrades = GetStudentGrades();
            string[] topStudents = studentGrades
                                    .Where(x => x.AverageGrade >= 5)
                                    .Select(x => x.Name).Distinct()
                                    .OrderBy(x => x)
                                    .ToArray();
            foreach (string student in topStudents)
            {
                double[] studentAverageGrades = studentGrades
                                                .Where(x => x.Name == student && x.AverageGrade >= 5)
                                                .Select(x => x.AverageGrade)
                                                .OrderByDescending(x => x)
                                                .ToArray();
                foreach (double studentAverageGrade in studentAverageGrades)

                {
                    Console.WriteLine("{0} -> {1:f2}", student, studentAverageGrade);
                }
                   
            }


        }
        private static Students[] GetStudentGrades()
        {
            int n = int.Parse(Console.ReadLine());
            Students[] grades = new Students[n];
            for (int i = 0; i < n; i++)
            {
                List<double> studentGrades = new List<double>();
                string[] data = Console.ReadLine()
                                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 1; j < data.Length; j++)
                {
                    studentGrades.Add(double.Parse(data[j]));
                    grades[i] = new Students() { Name = data[0], Grades = studentGrades };
                }
                    
            }
            return grades;
        }
    }
}
