
// Using the Singleton Logger
Logger logger = Logger.GetInstance();
logger.LogMessage("Application started");

// Using the Singleton Logger within a service
UserService userService = new();
userService.PerformUserAction("JohnDoe", "Login");

// Ensure that the same logger instance is used throughout the application
Logger anotherLogger = Logger.GetInstance();
Console.WriteLine($"Are both loggers the same instance? {ReferenceEquals(logger, anotherLogger)}");
