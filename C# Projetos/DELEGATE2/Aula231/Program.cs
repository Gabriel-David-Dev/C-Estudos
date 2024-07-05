using System;
using Aula231.Services;

namespace Aula231
{
    class Program
    {

        delegate void BinaryNumericOperation(double n1, double n2);

        static void Main(string[] args)
        {

            double n1 = 10.0;
            double n2 = 12.0;

            BinaryNumericOperation op = CalculationService.Sum;
            op += CalculationService.Max;

            op(n1, n2);

        }
    }
}