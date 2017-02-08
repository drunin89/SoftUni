using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SalesReport
{
    class Sale
    {
    
            public static string Town { get; set; }
            public static string Product { get; set; }
            public static double Price { get; set; }
            public static double QTY { get; set; }
            public static double Sum => Price * QTY;
    }
}
