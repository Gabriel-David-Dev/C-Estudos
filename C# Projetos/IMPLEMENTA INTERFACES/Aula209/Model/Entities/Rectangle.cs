using System.Globalization;

namespace Aula209.Model.Entities
{
    internal class Rectangle : AbstractShape
    {
        public double Widht { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Widht * Height;
        }

        public override string ToString()
        {
            return $"Rectangle color: {Color}, " +
                   $"Widht: {Widht.ToString("F2", CultureInfo.InvariantCulture)}, " +
                   $"Height: {Height.ToString("F2", CultureInfo.InvariantCulture)}, " +
                   $"Area: {Area().ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
