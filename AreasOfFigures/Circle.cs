namespace AreasOfFigures
{
    public class Circle : Figure
    {
        double radius;

        public Circle (double radius)
        {
            if (radius < 0)
                throw new Exception("Радиус не может быть отрицательным!");
            this.radius = radius;
        }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }
    }
}
