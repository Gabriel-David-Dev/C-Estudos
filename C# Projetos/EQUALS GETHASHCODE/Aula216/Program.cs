using System;
using Aula216.Entities;

namespace Aula216
{
    class Program
    {
        static void Main(string[] args)
        {

            Client clientA = new Client { Name = "Gabriel", Email = "isa@gmail.com"};
            Client clientB = new Client { Name = "Isabella", Email = "isa@gmail.com" };

            Console.WriteLine(clientA.Equals(clientB));
            Console.WriteLine(clientA == clientB);
            Console.WriteLine(clientA.GetHashCode());
            Console.WriteLine(clientB.GetHashCode());

        }
    }
}