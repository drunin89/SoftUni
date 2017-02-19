using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AdvertisementMessage
{
    class AdvertisementMessage
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var phrases = new List<string>()
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };
            var events = new List<string>()
            {
                "Now I feel good.",
                "I feel great!",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
            };
            var author = new List<string>()
            {
                   "Diana",
                    "Petya",
                    "Stella",
                    "Elena",
                    "Katya",
                    "Iva",
                    "Annie",
                    "Eva"
            };
            var cities = new List<string>()
            {
                   "Burgas",
                    "Sofia",
                    "Plovdiv",
                    "Varna",
                    "Ruse",

            };
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                int pRandom = rnd.Next(phrases.Count);
                int eRandom = rnd.Next(events.Count);
                int aRandom = rnd.Next(author.Count);
                int cRandom = rnd.Next(cities.Count);

                Console.WriteLine($"{phrases[pRandom]} {events[eRandom]} {author[aRandom]} – {cities[cRandom]}.");
            }

        }
    }
}
