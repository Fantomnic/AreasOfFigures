namespace AreasOfFigures
{
    // Чтобы добавить новую фигуру, достаточно унаследовать её от этого класса,
    // определить необходимые параметры (как, например, радиус для круга)
    // и реализовать метод Area()
    public abstract class Figure
    {
        public abstract double Area();

        public static double AreaOfSomeFigure(Figure f)
        {
            return f.Area();
        }
    }
}
