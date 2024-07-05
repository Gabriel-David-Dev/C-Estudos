using System;

namespace Aula222
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["name"] = "Gabriel";
            cookies["age"] = "23";
            cookies["phone"] = "4002-8922";
            cookies["phone"] = "7070-6060";
            cookies["email"] = "gabriel@gmail.com";
            

            foreach(KeyValuePair<string, string> data in cookies)
            {
                Console.WriteLine($"{data.Key}: {data.Value}");
            }

            cookies.Remove("email");

            Console.WriteLine();
            Console.WriteLine($"Total data: {cookies.Count}");

        }
    }
}
