using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.SquareFrame
{
    class SquareFrame
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var inner = "|";
            Console.Write("+");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");


            for (int row = 0; row < n - 2; row++)
            {
                inner = inner + " -";
            }



            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(inner);
                Console.WriteLine(" |");
            }



            Console.Write("+");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");





        }

    }
}
