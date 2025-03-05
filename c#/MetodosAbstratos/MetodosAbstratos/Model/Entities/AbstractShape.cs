using MetodosAbstratos.Model.Enums;

namespace MetodosAbstratos.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        protected AbstractShape() { }

        public AbstractShape(Color color)
        {
            this.Color = color;
        }

        public abstract double Area();
    }
}
