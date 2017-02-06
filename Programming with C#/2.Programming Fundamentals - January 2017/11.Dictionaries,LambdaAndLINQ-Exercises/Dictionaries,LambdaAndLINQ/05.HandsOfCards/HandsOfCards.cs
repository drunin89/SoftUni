namespace _05.HandsOfCards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class HandsOfCards
    {
        public static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var cardPowers = GetCardPowers();
            var cardTypes = GetCardTypes();
            var cards = new Dictionary<string, HashSet<int>>();
            while (line != "JOKER")
            {
                var tokens = line.Split(':');
                var names = tokens[0];
                var playerCards = tokens[1].Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                foreach (var card in playerCards)
                {
                    var cardPower = card.Substring(0, card.Length - 1).ToString();
                    var cardType = card.Substring(card.Length - 1).ToString();
                    var sum = cardPowers[cardPower] * cardTypes[cardType];
                    if (!cards.ContainsKey(names))
                    {
                        cards[names] = new HashSet<int>();
                    }
                    cards[names].Add(sum);
                }
                line = Console.ReadLine();
            }
            foreach (var pair in cards)
            {
                var name = pair.Key;
                var cardSum = pair.Value.Sum();
                Console.WriteLine($"{name}: {cardSum}");

            }

        }

        private static Dictionary<string, int> GetCardTypes()
        {
            var cardTypes = new Dictionary<string, int>();
            cardTypes["S"] = 4;
            cardTypes["H"] = 3;
            cardTypes["D"] = 2;
            cardTypes["C"] = 1;
            return cardTypes;
        }

        private static Dictionary<string, int> GetCardPowers()
        {
            var powers = new Dictionary<string, int>();
            for (int i = 2; i <= 10; i++)
            {
                powers[i.ToString()] = i;
            }
            powers["J"] = 11;
            powers["Q"] = 12;
            powers["K"] = 13;
            powers["A"] = 14;
            return powers;

        }
    }
}
