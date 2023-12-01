namespace TaleLearnCode.ReevaluatingSoftwareDesignPatterns.Observer;

// Concrete Observer that implements the IObserver interface
public record Investor(string Name) : IObserver
{

	public void Update(double stockPrice)
	{
		Console.WriteLine($"Investor {Name} received an update: Stock price for {Name} is {stockPrice}");

		// Unintended cascading update
		if (stockPrice > 110.00)
		{
			Console.WriteLine($"Investor {Name} decides to sell stocks.");
			// This update triggers another change in the subject
			// In a real-world scenario, this could lead to unintended cascading updates.


			/*
			 * The 'Inventor' class has an unintended cascading update.  When the
			 * stock price goes above a certain threshold, the inventor decides to
			 * sell stocks, triggering another update in the subject.
			 * 
			 * This unintended cascading update can lead to unexpected behavior,
			 * especially if other observers are also reacting to changes in the
			 * subject. In a real-world scenario, this could result in a chain
			 * reaction of updates
			 * 
			 * Please note that these difficulties are intentionally introduced for
			 * illustrative purposes, and in practice, careful design and
			 * consideration of the specific requirements can help mitigate such
			 * issues.
			 */

		}

	}

}