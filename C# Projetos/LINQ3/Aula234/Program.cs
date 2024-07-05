using System;
using Aula234.Entities;
using System.Linq;

namespace Aula234
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> products = new List<Product>();

            products.Add(new Product("Tv", 900.00));
            products.Add(new Product("Mouse", 50.00));
            products.Add(new Product("Tablet", 350.50));
            products.Add(new Product("HD Case", 80.90));

            List<string> newList = products.Select(p => p.Name.ToUpper()).ToList();

            foreach(string product in newList)
            {
                Console.WriteLine(product);
            }

        }        

    }
}
