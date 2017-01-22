using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.OddEvenPosition
{
    class OddEvenPosition
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double num = 0.00;
            double evensum = 0.00;
            double oddsum = 0.00;
            double oddmax = -1000000000.0;
            double oddmin = 1000000000.0;
            double evenmax = -1000000000.0;
            double evenmin = 1000000000.0;
            if (n < 0)
            {
                Console.WriteLine("Error");
            }
            else if (n == 0)
            {
                Console.WriteLine("OddSum=" + n);
                Console.WriteLine("OddMin=No");
                Console.WriteLine("OddMax=No");
                Console.WriteLine("EvenSum=" + n);
                Console.WriteLine("EvenMin=No");
                Console.WriteLine("EvenMax=No");
            }
            else if (n == 1)
            {
                num = double.Parse(Console.ReadLine());
                Console.WriteLine("OddSum=" + num);
                Console.WriteLine("OddMin=" + num);
                Console.WriteLine("OddMax=" + num);
                Console.WriteLine("EvenSum=0");
                Console.WriteLine("EvenMin=No");
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    num = double.Parse(Console.ReadLine());
                    if (i % 2 == 0)
                    {
                        evensum += num;
                        if (num > evenmax)
                        {
                            evenmax = num;
                        }
                        if (num < evenmin)
                        {
                            evenmin = num;
                        }

                    }
                    else
                    {
                        oddsum += num;
                        if (num > oddmax)
                        {
                            oddmax = num;
                        }
                        if (num < oddmin)
                        {
                            oddmin = num;
                        }
                    }
                }
            }
            Console.WriteLine("OddSum={0}", oddsum);
            Console.WriteLine("OddMin={0}", oddmin);
            Console.WriteLine("OddMax={0}", oddmax);
            Console.WriteLine("EvenSum={0}", evensum);
            Console.WriteLine("EvenMin={0}", evenmin);
            Console.WriteLine("EvenMax={0}", evenmax);
        }
    }
}
