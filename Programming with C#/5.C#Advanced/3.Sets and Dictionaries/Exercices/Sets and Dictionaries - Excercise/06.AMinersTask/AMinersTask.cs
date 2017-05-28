using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.AMinersTask
{
    class AMinersTask
    {
        static void Main(string[] args)
        {
            string input;
            var resources = new Dictionary<string, int>();

            while ((input = Console.ReadLine()) != "stop")
            {
                if (resources.ContainsKey(input))
                {
                    resources[input] += int.Parse(Console.ReadLine());
                }
                else
                {
                    resources[input] = int.Parse(Console.ReadLine());
                }
                
            }
            foreach (var pair in resources)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
            
        }
        
    }
}
