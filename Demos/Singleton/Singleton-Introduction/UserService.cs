namespace TaleLearnCode.ReevaluatingSoftwareDesignPatterns.Singleton;

/*
 * The 'UserService' class is a service that uses the 'Logger' Singleton
 * for logging user actions.
 * */

public class UserService
{

	private readonly Logger logger;

	public UserService()
	{
		logger = Logger.GetInstance();
	}

	public void PerformUserAction(string userName, string action)
	{
		// Some business logic

		// Log an event
		logger.LogMessage($"User '{userName}' performed action: {action}");

		// More business logic
	}
}