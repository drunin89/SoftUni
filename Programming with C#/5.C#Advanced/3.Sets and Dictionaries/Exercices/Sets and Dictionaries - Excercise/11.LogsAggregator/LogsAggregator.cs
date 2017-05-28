using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.LogsAggregator
{
    class LogsAggregator
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var listUsers = new SortedDictionary<string, SortedDictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split(' ');
                var user = line[1];
                string ip = line[0];
                var duration = int.Parse(line[2]);
                if (!listUsers.ContainsKey(user))
                {
                    listUsers.Add(user, new SortedDictionary<string, int>());
                }
                if (!listUsers[user].ContainsKey(ip))
                {
                    listUsers[user][ip] = 0;
                }
                listUsers[user][ip] += duration;

            }

            foreach (var outerPair in listUsers)
            {
                var sum = outerPair.Value.Values.Sum();

                Console.Write("{0}: {1} ", outerPair.Key, sum);
                Console.Write("[");
                Console.Write(string.Join(", ", outerPair.Value.Keys));
                Console.WriteLine("]");
            }
        }
    }
}
