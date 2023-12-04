using CalculaRetangulo.Entities;
using CalculaRetangulo.Services;
using System.Globalization;

namespace CalculaRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Entre a largura do retângulo: ");
                double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Entra a altura do retângulo: ");
                double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Retangulo retangulo = new Retangulo(largura, altura);


                Console.WriteLine();
                Console.WriteLine($"Area: " +
                    $"{Calculo.Area(largura, altura).ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Perimetro: " +
                    $"{Calculo.Perimetro(largura, altura).ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Diagonal: " +
                    $"{Calculo.Diagonal(largura, altura).ToString("F2", CultureInfo.InvariantCulture)}");
            }
            catch (Exception erro)
            {
                Console.WriteLine($"Erro: {erro.Message}");
            }
        }
    }
}
