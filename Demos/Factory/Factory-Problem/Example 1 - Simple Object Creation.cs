namespace TaleLearnCode.ReevaluatingSoftwareDesignPatterns.Factory.Example1.SimpleObjectCreation;


/* ****************************************************************************
											Simple approach without factories
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

// Client code
public static class SimpleClient
{
	public static void Demonstrate()
	{

		PrintBanner.Example1Simple();

		IShape circle = new Circle();
		circle.Draw();

		IShape square = new Square();
		square.Draw();

	}
}

/*
 * In this simple approach, there's no need for factories or interfaces for
 * object creation, as the project is small and the object creation logic is
 * straightforward.
 */