﻿using Aula240.Entities;
using System.Globalization;


namespace Aula240
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {

            Category c1 = new Category(1, "Tools", 2);
            Category c2 = new Category(2, "Computers", 1);
            Category c3 = new Category(3, "Electronics", 1);

            List<Product> products = new List<Product>();

            products.Add(new Product(1, "Computer", 1100.0, c2));
            products.Add(new Product(2, "Hammer", 90.0, c1));
            products.Add(new Product(3, "TV", 1700.0, c3));
            products.Add(new Product(4, "Notebook", 1300.0, c2));
            products.Add(new Product(5, "Saw", 80.0, c1));
            products.Add(new Product(6, "Tablet", 700.0, c2));
            products.Add(new Product(7, "Camera", 700.0, c3));
            products.Add(new Product(8, "Printer", 350.0, c3));
            products.Add(new Product(9, "MacBook", 1800.0, c2));
            products.Add(new Product(10, "Sound Bar", 700.0, c3));
            products.Add(new Product(11, "Level", 70.0, c1));

            //var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900);
            var r1 =
                from product in products
                where product.Category.Tier == 1 && product.Price < 900
                select product;
            Print("TIER 1 AND PRICE < 900:", r1);

            //var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            var r2 =
                from product in products
                where product.Category.Name == "Tools"
                select product.Name;
            Print("NAMES OF PRODUCTS FROM TOOLS", r2);

            //var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            var r3 =
                from product in products
                where product.Name[0] == 'C'
                select new
                {
                    product.Name,
                    product.Price,
                    CategoryName = product.Category.Name
                };
            Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT", r3);

            //var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            var r4 =
                from product in products
                where product.Category.Tier == 1
                orderby product.Price, product.Name
                select product;
            Print("TIER 1 ORDER BY PRICE THEN BY NAME", r4);

            //var r5 = r4.Skip(2).Take(4);
            var r5 =
                (from p in r4
                 select p).Skip(2).Take(4);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4", r5);

            //var r16 = products.GroupBy(p => p.Category);
            var r16 =
                from product in products
                group product by product.Category;
            foreach (IGrouping<Category, Product> group in r16)
            {
                Console.WriteLine($"Category: {group.Key.Name}: ");
                foreach (Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }



        }
    }
}
