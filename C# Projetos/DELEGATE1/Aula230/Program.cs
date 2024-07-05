using System;
using Aula230.Services;

namespace Aula230
{
    class Program
    {
        delegate double BinaryNumericOperation(double n1, double n2);

        static void Main(string[] args)
        {

            double n1 = 10.0;
            double n2 = 12.0;

            double result = CalculationService.Sum(n1, n2);

            BinaryNumericOperation op = CalculationService.Max;

            Console.WriteLine($"O maior número é: {CalculationService.Max(n1, n2)}");
            Console.WriteLine($"A soma é: {CalculationService.Sum(n1, n2)}");
            Console.WriteLine($"O quadrado do primeiro número é: {CalculationService.Square(n1)}");
            Console.WriteLine($"O quadrado do segundo número é: {CalculationService.Square(n2)}");

            Console.WriteLine(result);

            Console.WriteLine(op(n1, n2));


        }
    }
}