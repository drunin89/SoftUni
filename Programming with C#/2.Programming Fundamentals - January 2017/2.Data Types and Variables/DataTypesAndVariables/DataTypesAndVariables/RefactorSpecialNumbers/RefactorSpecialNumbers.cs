using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorSpecialNumbers
{
    class RefactorSpecialNumbers
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                int num = i;
                int total = 0;
                while (num > 0)
                {
                    total += num % 10;
                    num = num / 10;
                }
                bool result = (total == 5) || (total == 7) || (total == 11);
                Console.WriteLine($"{i} -> {result}");
           
            }

        }
    }
}
