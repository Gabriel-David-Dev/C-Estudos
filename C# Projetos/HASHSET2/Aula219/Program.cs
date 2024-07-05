using System;
using System.Collections.Generic;
using Aula219.Entities;

namespace Aula219
{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<Product> products = new HashSet<Product>();

            products.Add(new Product("TV", 2000.00));
            products.Add(new Product("Notebook", 5450.00));

            HashSet<Point> points = new HashSet<Point>();

            points.Add(new Point(5, 10));
            points.Add(new Point(2, 4));

            Product prod = new Product("TV", 2000.00);
            Console.WriteLine(products.Contains(prod));

            Point p = new Point(2, 4);
            Console.WriteLine(points.Contains(p));
        }
    }
}
