namespace Geometry;

public class Triangle : IFigure
{
    private double[] _properties;
    public double[] Properties { get => _properties; }

    /// <summary>
    /// Свойство, возвращающее true если фигура является прямоугольным треугольником и false в остальных случаях.
    /// </summary>
    public bool isRightTriangle 
    {
        get
        {
            if (_properties == null) return false;
            if (_properties.Length != 3) return false;
            if ((_properties[2] * _properties[2]) == (_properties[0] * _properties[0]) + (_properties[1] * _properties[1])) return true;
            return false;
        }
    }

    /// <summary>
    /// Нахождение площади
    /// </summary>
    /// <returns></returns>
    public double GetArea()
    {
        if (_properties == null) return 0;
        double semiperimeter = 0;
        //Нахождение полупериметра
        foreach (var side in _properties)
        {
            if (side == 0) return 0.0;
            semiperimeter += side;
        }
        semiperimeter /= 2;
        //Нахождение площади через перемножение полупериметра и его разности с каждой стороной
        double area = semiperimeter;

        foreach (var side in _properties)
        {
            area *= (semiperimeter - side);
        }

        area = Math.Sqrt(area);
        return area;
    }

    /// <summary>
    /// Задать новые стороны треугольника
    /// </summary>
    /// <param name="p"></param>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="ArgumentException"></exception>
    public void SetFigure(params double[] p)
    {
        if (p == null) throw new ArgumentNullException();
        if (p.Length != 3) throw new ArgumentException("В качестве параметров должнен быть массив с длиной 3х сторон");
        _properties = p;
        Array.Sort(_properties);
    }

    public Triangle(params double[] p)
    {
        if (p.Length!=3) throw new ArgumentException("В качестве параметров должнен быть массив с длиной 3х сторон");
        if (p[0] < 0 || p[1] < 0 || p[2] < 0) throw new ArgumentException("Стороны не могут быть отрицательными");
        _properties = p;
        Array.Sort(_properties);
    }
}
