namespace AreasOfFigures
{
    public class Triangle : Figure
    {
        double side1, side2, side3;

        public Triangle(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                throw new Exception("Сторона треугольника должна быть положительной!");
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public override double Area()
        {
            double semiperimeter = (side1 + side2 + side3) / 2;
            return Math.Sqrt(semiperimeter * (semiperimeter - side1) * (semiperimeter - side2) * (semiperimeter - side3));
        }

        public bool IsRectangular()
        {
            if (side1 * side1 == side2 * side2 + side3 * side3
                || side2 * side2 == side1 * side1 + side3 * side3
                || side3 * side3 == side1 * side1 + side2 * side2)
            {
                return true;
            }

            return false;
        }
    }
}
