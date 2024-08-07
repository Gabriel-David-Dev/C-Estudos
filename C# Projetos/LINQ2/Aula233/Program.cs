﻿using System;
using Aula233.Entities;

namespace Aula233
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

            products.ForEach(p => { p.Price += p.Price * 0.1; });

            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }

        }
    }
}