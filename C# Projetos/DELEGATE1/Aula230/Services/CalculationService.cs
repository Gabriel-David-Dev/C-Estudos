namespace Aula230.Services
{
    internal class CalculationService
    {
        public static double Max(double n1, double n2)
        {
            if (n1 == n2)
            {
                throw new Exception("Os números são iguais!");
            }
            else if (n1 > n2)
            {
                return n1;
            }
            else
            {
                return n2;
            }
        }

        public static double Sum(double n1, double n2)
        {
            return n1 + n2;
        }

        public static double Square(double num)
        {
            return num * num;
        }
    }
}
