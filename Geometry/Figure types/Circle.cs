namespace Geometry;

public class Circle : IFigure
{
    private double[] _properties;
    public double[] Properties { get => _properties; }


    /// <summary>
    /// Нахождение площади
    /// </summary>
    /// <returns></returns>
    public double GetArea()
    {
        if (Properties[0] >= 0) return (Properties[0] * Properties[0] * Math.PI);
        else throw new ArgumentOutOfRangeException();
    }
    /// <summary>
    /// Задать новый радиус круга
    /// </summary>
    /// <param name="p">Радиус</param>
    /// <exception cref="ArgumentNullException">Радиус null</exception>
    /// <exception cref="ArgumentException">Число параметров не соответствует </exception>
    public void SetFigure(params double[] p)
    {
        if (p == null) throw new ArgumentNullException();
        if (p.Length != 1) throw new ArgumentException("Должен быть только 1 параметр, означающий радиус");
        if (p[0] < 0) throw new ArgumentException("Радиус не может быть отрицательным");
        Properties[0] = p[0];
    }

    public Circle(params double[] p)
    {
        if (p == null) throw new ArgumentNullException();
        if (p.Length != 1) throw new ArgumentException("Должен быть только 1 параметр, означающий радиус");
        if (p[0] < 0) throw new ArgumentException("Радиус не может быть отрицательным");
        _properties = p;
    }
}
