using CompraDolar.Services;
using System.Globalization;

namespace CompraDolar
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Entre com a cotação do dólar: $");
                double dolarPreco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantos dólares vão ser comprados: $");
                double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double reais = CambioMoedaServices.ConversorDeMoeda(dolarPreco, dolar);

                Console.WriteLine($"Valor a ser pago em reais: R${reais.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            catch (Exception erro)
            {
                Console.WriteLine($"Erro: {erro.Message}");
            }
            

        }
    }
}
