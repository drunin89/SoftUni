using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _01.OddLines
{
    class OddLines
    {
        public static void Main()
        {
            string[] text = File.ReadAllLines("input.txt");

            File.WriteAllLines("output.txt", text.Where((line, index) => index % 2 == 1));
            

        }
    }
}
