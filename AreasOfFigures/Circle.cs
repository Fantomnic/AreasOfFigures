namespace AreasOfFigures
{
    public class Circle
    {
        double radius;

        public Circle (double radius)
        {
            this.radius = radius;
        }

        public double Area()
        {
            return Math.PI * radius * radius;
        }
    }
}
