namespace TaleLearnCode.ReevaluatingSoftwareDesignPatterns.Observer;


// Concrete Subject that implements the ISubject interface
public record StockMarket(string Name) : ISubject
{
	private double _stockPrice;
	private readonly List<IObserver> _observers = [];

	public void SetStockPrice(double price)
	{
		_stockPrice = price;
		NotifyObservers();
	}

	public void RegisterObserver(IObserver observer)
	{
		_observers.Add(observer);
		Console.WriteLine($"Investor {observer.Name} has subscribed for updates to '{Name}'");
	}

	public void RemoveObserver(IObserver observer)
	{
		_observers.Remove(observer);
		Console.WriteLine($"Investor {observer.Name} has unsubscribed for updates to '{Name}'");
	}

	public void NotifyObservers()
	{
		foreach (var observer in _observers)
		{
			observer.Update(_stockPrice);
		}
	}

}