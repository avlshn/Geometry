using Geometry;
namespace GeometryTest;

[TestClass]
public class FiguresTest
{
    [TestMethod]
    public void SetFigureFromString_ValidParameters_ReturnsArea()
    {
        string figureType = "circle";
        var figureProperties = new double[] {5};
        double expected = 78.539815;
        Figures figures = new Figures();

        figures.SetFigureFromString(figureType, figureProperties);

        double actual = figures.GetArea();
        Assert.AreEqual(expected, actual, 0.00001, "Неверное вычисление площади");
    }

    [TestMethod]
    public void SetFigureFromString_InvalidClassName_ShouldThrowArgumentNullException()
    {
        string figureType = "circle2";
        var figureProperties = new double[] { 5 };
        double expected = 78.539815;
        Figures figures = new Figures();


        Assert.ThrowsException<ArgumentNullException>(() => figures.SetFigureFromString(figureType, figureProperties));
    }

    [TestMethod]
    public void SetFigure_ValidParameters_ShouldBeRightTriangle()
    {
        var figureProperties = new double[] { 3, 4, 5 };
        bool expected = true;
        Figures figures = new Figures();

        figures.SetFigure<Triangle>(figureProperties);

        Assert.IsTrue(figures.isRightTriangle, "Неверное вычисление, isRightTriangle должно быть true");
    }

}