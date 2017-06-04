using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.OddLines
{
    class OddLines
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a file path: ");
            var filePath = Console.ReadLine();

            using (var reader = new StreamReader(filePath))
            using (var writer = new StreamWriter("../../result.txt"))
            {
                var readline = "";
                int counter = 1;
                while ((readline = reader.ReadLine()) != null)
                {
                    if (counter % 2 != 0)
                    {
                        writer.WriteLine($"{counter}{readline}");
                        
                    }
                    counter++;
                }
            }

        }
    }
}
