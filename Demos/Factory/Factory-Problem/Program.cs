do
{
	PrintBanner.Program();
	ConsoleKeyInfo userInput = Console.ReadKey(true);
	Console.WriteLine();
	if (userInput.Key is ConsoleKey.D1 or ConsoleKey.NumPad1)
		Example1Factory.FactoryClient.Demonstrate();
	else if (userInput.Key is ConsoleKey.D2 or ConsoleKey.NumPad2)
		Example1Simple.SimpleClient.Demonstrate();
	else if (userInput.Key is ConsoleKey.D3 or ConsoleKey.NumPad3)
		Example2Factory.FactoryClient.Demonstrate();
	else if (userInput.Key is ConsoleKey.D4 or ConsoleKey.NumPad4)
		Example2Simple.SimpleClient.Demonstrate();
	else if (userInput.Key is ConsoleKey.Escape)
		break;
	Console.WriteLine();
	Console.Write("Press any key to continue...");
	Console.ReadKey(true);
} while (true);