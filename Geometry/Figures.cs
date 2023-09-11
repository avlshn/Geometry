namespace Geometry;

/// <summary>
/// Класс, содержащий фигуры, через который можно работать с ними. 
/// Добавление новых фигур осуществляется добавлением новых классов, реализующих интерфейс IFigure
/// </summary>
public class Figures
{
	private IFigure _someFigure;

	public IFigure SomeFigure
	{
		get { return _someFigure; }
	}


	/// <summary>
	/// Свойство, возвращающее true если фигура является прямоугольным треугольником и false в остальных случаях.
	/// </summary>
	public bool isRightTriangle
	{
		get
		{
			if (SomeFigure is Triangle triangle) return triangle.isRightTriangle;
			return false;
		}
	}

	//Не совсем понял "Вычисление площади фигуры без знания типа фигуры в compile-time", 
	//предположил, что уже в момент выполненя программы может быть задана любая фигура и набор параметров
	//в виде массива (длина сторон, радиус и т.д.), определенная функция должна быть вызвана GUI или клиентом и вернуть
	//площадь в зависимости от параметров. Поэтому я написал две разных функции, предоставляющие эту возможность.


	/// <summary>
	/// Задать фигуру через функцию, передавая ей тип фигуры 
	/// </summary>
	/// <param name="p"> Свойства фигуры </param>


	public void SetFigure<T>(params double[] p)
		where T : IFigure
	{
		T t = (T)Activator.CreateInstance(typeof(T), p);
		_someFigure = t;
	}

	/// <summary>
	/// Аналогично предыдущему, но через строку название фигуры
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="figure"> Название класса (фигуры) на английском </param>
	/// <param name="p"> Свойства фигуры </param>


	public void SetFigureFromString(string figure, params double[] p)

	{
		figure = "Geometry." + figure;
		var t = Activator.CreateInstance(Type.GetType(figure, false, true), p);
		if (t is IFigure T) _someFigure = T;
	}

	public void ChangeFigureProperties(params double[] p) => _someFigure.SetFigure(p);


	/// <summary>
	/// Пролучить площадь фигуры
	/// </summary>
	/// <returns></returns>
	public double GetArea()
	{
		return _someFigure.GetArea();
	}
}
