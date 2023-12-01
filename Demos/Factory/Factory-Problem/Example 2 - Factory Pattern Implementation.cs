namespace TaleLearnCode.ReevaluatingSoftwareDesignPatterns.Factory.Example2.FactoryPatternImplementation;


/* ****************************************************************************
											Factory Pattern implementation
	 **************************************************************************** */

/*
 * Now, let's see how applying the Factory Pattern might introduce unintended
 * consequences in this scenario
 */

// Shape interface
public interface IShape
{
	void Draw();
}

// Concrete shapes
public class Circle : IShape
{
	public void Draw()
	{
		Console.WriteLine("Drawing a circle");
	}
}

public class Square : IShape
{
	public void Draw()
	{
		Console.WriteLine("Drawing a square");
	}
}

// Extended shapes with styles
public class DottedCircle : IShape
{
	public void Draw()
	{
		Console.WriteLine("Drawing a dotted circle");
	}
}

public class RoundedSquare : IShape
{
	public void Draw()
	{
		Console.WriteLine("Drawing a rounded square");
	}
}

// Factory interface
public interface IShapeFactory
{
	IShape CreateShape();
}

// Concrete factories
public class CircleFactory : IShapeFactory
{
	public IShape CreateShape()
	{
		return new Circle();
	}
}

public class SquareFactory : IShapeFactory
{
	public IShape CreateShape()
	{
		return new Square();
	}
}

public class DottedCircleFactory : IShapeFactory
{
	public IShape CreateShape()
	{
		return new DottedCircle();
	}
}

public class RoundedSquareFactory : IShapeFactory
{
	public IShape CreateShape()
	{
		return new RoundedSquare();
	}
}

// Client code
public static class FactoryClient
{
	public static void Demonstrate()
	{

		PrintBanner.Example2Factory();

		IShapeFactory circleFactory = new CircleFactory();
		IShape circle = circleFactory.CreateShape();
		circle.Draw();

		IShapeFactory squareFactory = new SquareFactory();
		IShape square = squareFactory.CreateShape();
		square.Draw();

		IShapeFactory dottedCircleFactory = new DottedCircleFactory();
		IShape dottedCircle = dottedCircleFactory.CreateShape();
		dottedCircle.Draw();

		IShapeFactory roundedSquareFactory = new RoundedSquareFactory();
		IShape roundedSquare = roundedSquareFactory.CreateShape();
		roundedSquare.Draw();

	}
}

/*
 * In this Factory Pattern implementation, the introduction of factories and
 * interfaces for each shape might be considered over-engineering for the
 * increased complexity of the application. As the number of shapes and
 * variations grows, managing numerous factories and interfaces can become
 * challenging.
 * 
 * For larger projects, especially those with evolving requirements, it's
 * crucial to carefully consider the trade-offs between the benefits of design
 * patterns, such as the Factory Pattern, and the potential complexities they
 * introduce. In some cases, a more flexible and extensible design might be
 * appropriate, while in others, a simpler approach without factories may still
 * be effective.
 */