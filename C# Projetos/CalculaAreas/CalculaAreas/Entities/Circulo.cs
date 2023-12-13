using CalculaAreas.Entities.Enums;

namespace CalculaAreas.Entities
{
    internal class Circulo : Forma
    {
        public double Raio { get; set; }

        public Circulo(Cor cor, double raio)
            : base(cor)
        {
            Raio = raio;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Raio, 2);
        }

        public override string ToString()
        {
            return $"Circulo: {base.ToString()}";
        }
    }
}
