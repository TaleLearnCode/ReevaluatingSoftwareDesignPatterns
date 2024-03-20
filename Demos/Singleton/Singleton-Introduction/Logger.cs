namespace TaleLearnCode.ReevaluatingSoftwareDesignPatterns.Singleton;

/*
	 The 'Logger' class is a Singleton with a private constructor and a
	 'GetInstance' method for lazy initialization.
*/

public class Logger
{
	private static Logger? instance;

	// Additional properties or methods can be added here

	// Private constructor to prevent instantiation
	private Logger()
	{
		// Initialization code here
	}

	// Lazy initialization, create instance only if needed
	public static Logger GetInstance()
	{
		instance ??= new Logger();
		return instance;
	}

	public void LogMessage(string message) => Console.WriteLine($"Logging: {message}");

}