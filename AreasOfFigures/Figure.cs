namespace AreasOfFigures
{
    public abstract class Figure
    {
        public abstract double Area();

        public static double AreaOfSomeFigure(Figure f)
        {
            return f.Area();
        }
    }
}
