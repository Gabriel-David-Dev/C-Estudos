namespace CalculaRetangulo.Services
{
    internal class Calculo
    {
        public static double Area(double largura, double altura)
        {
            return largura * altura;
        }

        public static double Perimetro(double largura, double altura)
        {
            return (largura + altura) * 2;
        }

        public static double Diagonal(double largura, double altura)
        {
            return Math.Sqrt((largura * largura) + (altura * altura));
        }
    }
}
