using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.BlankReceipt
{
    class BlankReceipt
    {
        public static void Main(string[] args)
        {
            PrintReceiptHeader();
            PrintReceiptBody();
            PrintReceiptFooter();

        }
        public static void PrintReceiptHeader()
        {
            Console.WriteLine("CASH RECEIPT\n------------------------------");
        }
        public static void PrintReceiptBody()
        {
            Console.WriteLine("Charged to____________________\nReceived by___________________");
        }
        public static void PrintReceiptFooter()
        {
            Console.WriteLine("------------------------------\n\u00A9 SoftUni");
        }

    }
}
