namespace TaleLearnCode.ReevaluatingSoftwareDesignPatterns.Observer;

public interface IObserver
{
	void Update(double stockPrice);
	string Name { get; init; }
}

public interface ISubject
{
	void RegisterObserver(IObserver observer);
	void RemoveObserver(IObserver observer);
	void NotifyObservers();
	string Name { get; init; }
}