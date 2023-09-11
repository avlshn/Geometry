using Geometry;

namespace GeometryTest;

[TestClass]
public class TriangleTest
{
    [TestMethod]
    public void SetFigure_ValidParameters_ReturnsArea()
    {
        double[] sides = new double[] {4, 3, 5 };
        double expectedArea = 6;
        double[] expectedSides = new double[] { 3, 4, 5 }; ;

        Triangle triangle = new Triangle(1, 2, 3);
        triangle.SetFigure(sides);

        var actual = triangle.GetArea();
        Assert.AreEqual(expectedArea, actual, 0.001, "Неверно вычислена площадь");
        CollectionAssert.AreEqual(expectedSides, triangle.Properties, "Функция не обновила стороны или не выполнила сортировку");
    }

    [TestMethod]
    public void SetFigure_ZeroSide_ReturnsZero()
    {
        double[] sides = new double[] { 3, 0, 5 };
        double expectedArea = 0;
        double[] expectedSides = new double[] { 0, 3, 5 }; ;

        Triangle triangle = new Triangle(1, 2, 3);
        triangle.SetFigure(sides);

        var actual = triangle.GetArea();
        Assert.AreEqual(expectedArea, actual, 0.001, "Неверно вычислена площадь");
        CollectionAssert.AreEqual(expectedSides, triangle.Properties, "Функция не обновила стороны или не выполнила сортировку");
    }

    [TestMethod]
    public void SetFigure_NullParameters_ShouldThrowArgumentNullException()
    {
        Triangle triangle = new Triangle(1, 2, 3);

        Assert.ThrowsException<ArgumentException>(() => triangle.SetFigure());
    }

    [TestMethod]
    public void SetFigure_TwoParameters_ShouldThrowArgumentException()
    {
        Triangle triangle = new Triangle(1, 2, 3);

        Assert.ThrowsException<ArgumentException>(() => triangle.SetFigure(3, 4));
    }

    [TestMethod]
    public void SetFigure_NegativeParameters_ShouldThrowArgumentException()
    {
        Triangle triangle = new Triangle(1, 2, 3);

        Assert.ThrowsException<ArgumentException>(() => triangle.SetFigure(-3));
    }
}
