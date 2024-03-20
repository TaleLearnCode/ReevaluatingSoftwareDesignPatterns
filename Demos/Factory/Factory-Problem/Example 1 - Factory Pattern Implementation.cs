namespace TaleLearnCode.ReevaluatingSoftwareDesignPatterns.Factory.Example1.FactoryPatternImplementation;

/* ****************************************************************************
											Factory Pattern implementation
	 **************************************************************************** */


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

// Client code
public static class FactoryClient
{
	public static void Demonstrate()
	{

		PrintBanner.Example1Factory();

		IShapeFactory circleFactory = new CircleFactory();
		IShape circle = circleFactory.CreateShape();
		circle.Draw();

		IShapeFactory squareFactory = new SquareFactory();
		IShape square = squareFactory.CreateShape();
		square.Draw();

	}
}

/*
 * In this approach, the client code is more complex, but the object creation
 * logic is encapsulated in the factories. This allows for more flexibility in
 * the future, as the client code can be modified to use different factories
 * without having to change the object creation logic.
 * 
 * While this design pattern provides flexibility for extending the system with
 * new shapes, it might be considered over-engineering for a small project. The
 * Factory Pattern introduces additional classes and interfaces, making the code
 * more complex than necessary.
 */