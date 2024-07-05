using Aula209.Model.Interfaces;
using Aula209.Model.Enums;

namespace Aula209.Model.Entities
{
    internal abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
