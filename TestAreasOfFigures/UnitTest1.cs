using AreasOfFigures;

namespace TestAreasOfFigures
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCircle1()
        {
            double r = 10;
            double expected = Math.PI * 100;
            Circle c = new Circle(r);
            double actual = c.Area();
            Assert.AreEqual(expected, actual, "ѕлощадь круга через метод класса посчитана неверно");
        }

        [TestMethod]
        public void TestCircle2()
        {
            double r = 10;
            double expected = Math.PI * 100;
            Circle c = new(r);
            double actual = Figure.AreaOfSomeFigure(c);
            Assert.AreEqual(expected, actual, "ѕлощадь круга через статический метод посчитана неверно");
        }

        [TestMethod]
        public void TestTriangle1()
        {
            double s1 = 10, s2 = 10, s3 = 16;
            double expected = 48;
            Triangle t = new(s1, s2, s3);
            double actual = t.Area();
            Assert.AreEqual(expected, actual, "ѕлощадь треугольника через метод класса посчитана неверно");
            Assert.AreEqual(t.IsRectangular(), false, "Ќаличие пр€мого угла определено неверно (ложноположительно)");
        }

        [TestMethod]
        public void TestTriangle2()
        {
            double s1 = 3, s2 = 4, s3 = 5;
            double expected = 6;
            Triangle t = new(s1, s2, s3);
            double actual = Figure.AreaOfSomeFigure(t);
            Assert.AreEqual(expected, actual, "ѕлощадь треугольника через статический метод посчитана неверно");
            Assert.AreEqual(t.IsRectangular(), true, "Ќаличие пр€мого угла определено неверно (ложноотрицательно)");
        }
    }
}