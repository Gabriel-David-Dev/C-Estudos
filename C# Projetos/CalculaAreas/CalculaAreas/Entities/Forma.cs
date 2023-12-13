using CalculaAreas.Entities.Enums;

namespace CalculaAreas.Entities
{
    internal abstract class Forma
    {
        public Cor Cor { get; set; }

        public Forma(Cor cor)
        {
            Cor = cor;
        }

        public static char ValidaForma(char resposta)
        {
            while(resposta != 'r' && resposta != 'c')
            {
                Console.WriteLine("Escolha inválida, tente novamente!");
                Console.Write("Retangulo ou Circulo (r/c): ");
                resposta = char.Parse(Console.ReadLine().ToLower());
            }
            return resposta;
        }

        public abstract double Area();

        public override string ToString()
        {
            return $"{Area().ToString("F2")}";
        }
    }
}
