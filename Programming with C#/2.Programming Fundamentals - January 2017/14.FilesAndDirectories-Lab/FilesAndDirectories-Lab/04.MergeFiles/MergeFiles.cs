using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _04.MergeFiles
{
    class MergeFiles
    {
        public static void Main()
        {
            var firstLine = File.ReadAllLines("FileOne.txt").ToList();
            var secondLine = File.ReadAllLines("FileTwo.txt").ToList();
            firstLine.AddRange(secondLine);
            firstLine.Sort();

            File.AppendAllLines(@"output.txt", firstLine);

        }
    }
}
