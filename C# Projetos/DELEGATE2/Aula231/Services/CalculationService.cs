using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula231.Services
{
    internal class CalculationService
    {
        public static void Max(double n1, double n2)
        {
            if (n1 == n2)
            {
                Console.WriteLine("Valores iguais!");
            }
            else if (n1 > n2)
            {
                Console.WriteLine(n1);
            }
            else
            {
                Console.WriteLine(n2);
            }
        }

        public static void Sum(double n1, double n2)
        {
            Console.WriteLine(n1 + n2);
        }
    }
}
