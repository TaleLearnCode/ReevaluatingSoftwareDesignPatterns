namespace TaleLearnCode.ReevaluatingSoftwareDesignPatterns.Factory;

// Factory interface
public interface IFactory
{
	IProduct CreateProduct();
}

// Concrete factory
public class ConcreteFactoryA : IFactory
{
	public IProduct CreateProduct()
	{
		return new ConcreteProductA();
	}
}

// Concrete factory
public class ConcreteFactoryB : IFactory
{
	public IProduct CreateProduct()
	{
		return new ConcreteProductB();
	}
}