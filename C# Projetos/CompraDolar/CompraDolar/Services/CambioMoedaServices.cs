namespace CompraDolar.Services
{
    internal class CambioMoedaServices
    {
        public static double ConversorDeMoeda(double dolarPreco, double qtdDolar)
        {
            double imposto = 0.06;
            double reais = dolarPreco * qtdDolar;
            reais += + reais * imposto;
            return reais;
        }
    }
}
