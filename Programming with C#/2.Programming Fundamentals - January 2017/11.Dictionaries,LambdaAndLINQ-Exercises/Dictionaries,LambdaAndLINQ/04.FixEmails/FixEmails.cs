namespace _04.FixEmails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FixEmails
    {
        public static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var emails = new Dictionary<string, string>();

            while (line != "stop")
            {
                var name = line;
                var email = Console.ReadLine();
                emails[name] = email;
                line = Console.ReadLine();
            }
            var fixedEmails = emails
                .Where(a => !a.Value.ToLower().EndsWith("us") && !a.Value.ToLower().EndsWith("uk"))
                .ToDictionary(p => p.Key, p => p.Value);
            foreach (var item in fixedEmails)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
