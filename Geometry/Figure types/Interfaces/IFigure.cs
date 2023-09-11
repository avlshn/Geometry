namespace Geometry;


/// <summary>
/// Интерфейс, реализуя который, можно добавлять новые фигуры.
/// </summary>
public interface IFigure
{
    public double[] Properties { get; }
    public double GetArea();
    public void SetFigure(params double[] p);

}
