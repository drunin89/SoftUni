using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Grades
{
    class Grades
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double ocenka = 0;
            double counter1 = 0;
            double counter2 = 0;
            double counter3 = 0;
            double counter4 = 0;
            double sum = 0;
            double average = 0;
            for (int i = 1; i <= n; i++)
            {
                ocenka = double.Parse(Console.ReadLine());
                sum += ocenka;
                if (ocenka >= 5)
                {
                    counter1 += 1;
                }
                else if (ocenka >= 4 && ocenka < 5)
                {
                    counter2 += 1;
                }
                else if (ocenka >= 3 && ocenka < 4)
                {
                    counter3 += 1;
                }
                else if (ocenka < 3)
                {
                    counter4 += 1;
                }

            }
            average = sum / n;
            Console.WriteLine("Top students: {0:f2}%", counter1 / n * 100);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", counter2 / n * 100);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", counter3 / n * 100);
            Console.WriteLine("Fail: {0:f2}%", counter4 / n * 100);
            Console.WriteLine("Average: {0:f2}", average);
        }
    }
}
