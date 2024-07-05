using System;
using System.IO;
using System.Collections.Generic;
using Aula211.Entities;

namespace Aula211
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Gabriel\Desktop\teste.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }

        }
    }
}
