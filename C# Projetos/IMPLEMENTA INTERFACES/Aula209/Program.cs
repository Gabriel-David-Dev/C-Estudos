using Aula209.Model.Entities;
using Aula209.Model.Enums;
using Aula209.Model.Interfaces;
using System;

namespace Aula209 { 
    class Program
    {
        static void Main(string[] args)
        {

            IShape s1 = new Circle() { Radius = 2.0, Color = Color.White };
            IShape s2 = new Rectangle() { Widht = 3.5, Height = 4.2, Color = Color.Black };

            Console.WriteLine(s1);
            Console.WriteLine(s2);

        }
    }
}