using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.OfficeStuff
{
    class OfficeStuff
    {
        public static void Main()
        {
            var companies = GetCompanies();
            PrintCompanies(companies);
        }

        private static void PrintCompanies(HashSet<Company> companies)
        {
            foreach (var company in companies.OrderBy(c => c.Name))
            {
                var orderHistory = string.Join(", ", company.Orders.Select(p => $"{p.Name}-{p.Amount}"));
                Console.WriteLine($"{company.Name}: {orderHistory}");
            }
        }

        private static HashSet<Company> GetCompanies()
        {
            var companies = new HashSet<Company>();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var indexOfFirstSlash = input.IndexOf('-');
                var indexOfLastSlash = input.LastIndexOf('-');

                var name = input.Substring(1, indexOfFirstSlash - 1).Trim();
                var amount = int.Parse(input.Substring(indexOfFirstSlash + 2, indexOfLastSlash - indexOfFirstSlash - 2));
                var product = input.Substring(indexOfLastSlash + 2).Trim('|');

                var currentCompany = companies.Where(c => c.Name == name).FirstOrDefault();

                if (currentCompany == null)
                {
                    currentCompany = new Company
                    {
                        Name = name,
                        Orders = new List<Product>()
                    };

                    companies.Add(currentCompany);
                }

                var currentProduct = currentCompany.Orders.Where(p => p.Name == product).FirstOrDefault();

                if (currentProduct == null)
                {
                    currentProduct = new Product
                    {
                        Name = product,
                        Amount = 0
                    };

                    currentCompany.Orders.Add(currentProduct);
                }

                currentProduct.Amount += amount;
            }

            return companies;
        }
        class Product
        {
            public string Name { get; set; }

            public int Amount { get; set; }
        }

        class Company
        {
            public string Name { get; set; }

            public List<Product> Orders { get; set; }
        }
    }
}
