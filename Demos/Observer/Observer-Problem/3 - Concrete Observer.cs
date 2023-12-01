namespace TaleLearnCode.ReevaluatingSoftwareDesignPatterns.Observer;

// Concrete Observer that implements the IObserver interface
public record Investor(string Name) : IObserver
{

	public void Update(double stockPrice) => Console.WriteLine($"Investor {Name} received an update: Stock price for {Name} is {stockPrice}");

}