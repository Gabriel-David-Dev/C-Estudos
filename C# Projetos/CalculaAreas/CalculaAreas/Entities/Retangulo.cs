using CalculaAreas.Entities.Enums;

namespace CalculaAreas.Entities
{
    internal class Retangulo : Forma
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public Retangulo(Cor cor, double largura, double altura)
            : base(cor)
        {
            Largura = largura;
            Altura = altura;
        }

        public override double Area()
        {
            return Largura * Altura;
        }

        public override string ToString()
        {
            return $"Retangulo: {base.ToString()}";
        }
    }
}
