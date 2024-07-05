using Aula232.Entities;

namespace Aula232
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> products = new List<Product>();

            products.Add(new Product("TV", 900.00));
            products.Add(new Product("Mouse", 50.00));
            products.Add(new Product("Tablet", 350.50));
            products.Add(new Product("HD Case", 80.90));

            products.RemoveAll(ProductTester);

            foreach(Product product in products)
            {
                Console.WriteLine(product);
            }

        }

        public static bool ProductTester(Product prod)
        {
            return prod.Price >= 100.00;
        }
    }
}