﻿using System;
using System.Collections.Generic;

namespace Aula217
{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Computer"));

            foreach(string info in set)
            {
                Console.WriteLine(info);
            }

        }
    }
}