using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.GreaterNumber
{
    class GreaterNumber
    {
        static void Main(string[] args)
        {
            var firstNum = double.Parse(Console.ReadLine());
            var secondNum = double.Parse(Console.ReadLine());
            if (firstNum > secondNum)
            {
                Console.WriteLine("Greater number: " + firstNum);
            }
            else
            {
                Console.WriteLine("Greater number: " + secondNum);
            }
        }
    }
}
