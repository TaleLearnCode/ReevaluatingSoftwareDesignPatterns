namespace TaleLearnCode.ReevaluatingSoftwareDesignPatterns.Factory;

// Product interface
public interface IProduct
{
	void Display();
}

// Concrete product
public class ConcreteProductA : IProduct
{
	public void Display() => Console.WriteLine("Concrete Product A");
}

// Concrete product
public class ConcreteProductB : IProduct
{
	public void Display() => Console.WriteLine("Concrete Product B");
}