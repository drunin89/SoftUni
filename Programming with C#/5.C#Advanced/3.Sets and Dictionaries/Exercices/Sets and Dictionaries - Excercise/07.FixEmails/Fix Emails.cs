using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            var emails = new Dictionary<string, string>();
            var modifiedEmails = new Dictionary<string, string>();
            string input;
            while ((input = Console.ReadLine()) != "stop")
            {
                emails[input] = Console.ReadLine();
            }

            foreach (var pair in emails)
            {
                if (!pair.Value.EndsWith("uk") && !pair.Value.EndsWith("us"))
                {
                    modifiedEmails[pair.Key] = pair.Value;
                }
                
            }

            foreach (var pair in modifiedEmails)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
            
        }
    }
}
