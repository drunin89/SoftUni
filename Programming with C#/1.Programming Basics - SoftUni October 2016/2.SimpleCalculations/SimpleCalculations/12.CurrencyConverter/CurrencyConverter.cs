using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var suma = Double.Parse(Console.ReadLine());
            var valutaIn = Console.ReadLine();
            var valutaOut = Console.ReadLine();
            if (valutaIn == "BGN")
            {

                if (valutaOut == "BGN")
                {
                    Console.WriteLine(suma);
                }
                else if (valutaOut == "USD")
                {
                    Console.WriteLine(suma / 1.79549);
                }
                else if (valutaOut == "EUR")
                {
                    Console.WriteLine(suma / 1.95583);
                }
                else if (valutaOut == "GBP")
                {
                    Console.WriteLine(suma / 2.53405);
                }
                else
                {
                    Console.WriteLine("Nepravilno vavedeni danni");
                }
            }
            if (valutaIn == "USD")
            {

                if (valutaOut == "USD")
                {
                    Console.WriteLine(suma);
                }
                else if (valutaOut == "BGN")
                {
                    Console.WriteLine(suma * 1.79549);
                }
                else if (valutaOut == "EUR")
                {
                    Console.WriteLine((suma * 1.79549) / 1.95583);
                }
                else if (valutaOut == "GBP")
                {
                    Console.WriteLine((suma * 1.79549) / 2.53405);
                }
                else
                {
                    Console.WriteLine("Nepravilno vavedeni danni");
                }
            }
            if (valutaIn == "EUR")
            {

                if (valutaOut == "EUR")
                {
                    Console.WriteLine(suma);
                }
                else if (valutaOut == "USD")
                {
                    Console.WriteLine((suma * 1.95583) / 1.79549);
                }
                else if (valutaOut == "BGN")
                {
                    Console.WriteLine(suma * 1.95583);
                }
                else if (valutaOut == "GBP")
                {
                    Console.WriteLine((suma * 1.95583) / 2.53405);
                }
                else
                {
                    Console.WriteLine("Nepravilno vavedeni danni");
                }
            }
            if (valutaIn == "GBP")
            {

                if (valutaOut == "GBP")
                {
                    Console.WriteLine(suma);
                }
                else if (valutaOut == "USD")
                {
                    Console.WriteLine((suma * 2.53405) / 1.79549);
                }
                else if (valutaOut == "BGN")
                {
                    Console.WriteLine(suma * 2.53405);
                }
                else if (valutaOut == "EUR")
                {
                    Console.WriteLine((suma * 2.53405) / 1.95583);
                }
                else
                {
                    Console.WriteLine("Nepravilno vavedeni danni");
                }
            }



        }
    }
}
