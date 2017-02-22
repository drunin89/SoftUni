using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.NetherRealms
{
    class NetherRealms
    {
        public static void Main()
        {
            string[] demons = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .OrderBy(d => d)
                .ToArray();

            foreach (string demon in demons)
            {
                double demonHealth = GetDemonHealth(demon);
                decimal demonDamage = GetDemonDamage(demon);
                Console.WriteLine($"{demon} - {demonHealth} health, {demonDamage:F2} damage");
            }
        }

        private static decimal GetDemonDamage(string demon)
        {
            string demontDamagePattern = @"[\-\+]?[\d]+(?:[\.]*[\d]+|[\d]*)";
            var regex = new Regex(demontDamagePattern);
            var collection = regex.Matches(demon);
            decimal damage = 0;
            foreach (var number in collection)
            {
                damage += decimal.Parse(number.ToString());
            }

            foreach (char c in demon.Where(c => c == '*' || c == '/'))
            {
                if (c == '*')
                {
                    damage *= 2;
                }
                else
                {
                    damage /= 2;
                }
            }

            return damage;
        }

        private static double GetDemonHealth(string demon)
        {
            string demonHealthPattern = @"[^\d\.\+\-\*\/\s\,]";
            var regex = new Regex(demonHealthPattern);
            var collection = regex.Matches(demon);
            double health = 0;
            foreach (Match str in collection)
            {
                foreach (char c in str.ToString())
                {
                    health += (int)c;
                }
            }

            return health;
        }
    }
}
