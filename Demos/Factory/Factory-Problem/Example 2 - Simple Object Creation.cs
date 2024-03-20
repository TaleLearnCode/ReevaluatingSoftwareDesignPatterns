namespace TaleLearnCode.ReevaluatingSoftwareDesignPatterns.Factory.Example2.SimpleObjectCreation;


/* ****************************************************************************
											Simple approach without factories
	 **************************************************************************** */

/*
 * Consider a graphic design application that allows users to create different
 * types of shapes based on user input. The application has evolved, and the
 * shapes can now have various styles and properties.
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

// Client code
public static class SimpleClient
{
	public static void Demonstrate()
	{

		PrintBanner.Example2Simple();

		IShape circle = new Circle();
		circle.Draw();

		IShape square = new Square();
		square.Draw();

		IShape dottedCircle = new DottedCircle();
		dottedCircle.Draw();

		IShape roundedSquare = new RoundedSquare();
		roundedSquare.Draw();

	}
}

/*
 * In this extended scenario, the application has evolved to include new
 * shapes and variations without the need for factories, as the object
 * creation logic is still manageable.
 */