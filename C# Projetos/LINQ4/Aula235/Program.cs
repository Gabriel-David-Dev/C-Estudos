using System;

namespace Aula235
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 1, 2, 3, 4, 5 };

            IEnumerable<int> result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);

            foreach(var info in result)
            {
                Console.WriteLine(info);
            }
            

        }
    }
}