using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FirstName
{
    class FirstName
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split();
            var letters = Console.ReadLine().ToLower().ToCharArray().Where(c => c != ' ').ToArray();

            var filteredNames = names.Where(n => letters.Contains(char.ToLower(n[0]))).ToArray();

            Console.WriteLine((filteredNames.Length == 0)
                ? "No match"
                : filteredNames.OrderBy(n => n).First());
        }
    }
}
