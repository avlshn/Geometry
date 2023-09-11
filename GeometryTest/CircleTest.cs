using Geometry;

namespace GeometryTest;
[TestClass]
public class CircleTest
{
    [TestMethod]
    public void SetFigure_ValidParameters_ReturnsArea()
    {
        double radius = 10;
        double expectedArea = 314.159268;
        double expectedRadius = 10;

        Circle circle = new Circle(5);
        circle.SetFigure(radius);

        var actual = circle.GetArea();
        Assert.AreEqual(expectedArea, actual, 0.001, "Неверно вычислена площадь");
        Assert.AreEqual(expectedRadius, circle.Properties[0], 0.001, "Функция не обновила радиус");
    }

    [TestMethod]
    public void SetFigure_ZeroRadius_ReturnsZero()
    {
        double radius = 0;
        double expectedArea = 0;
        double expectedRadius = 0;

        Circle circle = new Circle(5);
        circle.SetFigure(radius);

        var actual = circle.GetArea();
        Assert.AreEqual(expectedArea, actual, 0.001, "Неверно вычислена площадь");
        Assert.AreEqual(expectedRadius, circle.Properties[0], 0.001, "Функция не обновила радиус");
    }

    [TestMethod]
    public void SetFigure_NullParameters_ShouldThrowArgumentNullException()
    {
        Circle circle = new Circle(1);

        Assert.ThrowsException<ArgumentException>(() => circle.SetFigure());
    }

    [TestMethod]
    public void SetFigure_TwoParameters_ShouldThrowArgumentException()
    {
        Circle circle = new Circle(1);

        Assert.ThrowsException<ArgumentException>(() => circle.SetFigure(3, 4));
    }

    [TestMethod]
    public void SetFigure_NegativeParameters_ShouldThrowArgumentException()
    {
        Circle circle = new Circle(1);

        Assert.ThrowsException<ArgumentException>(() => circle.SetFigure(-3));
    }
}
