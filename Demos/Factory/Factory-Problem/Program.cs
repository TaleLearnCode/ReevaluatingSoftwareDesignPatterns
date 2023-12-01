using Example1Factory = TaleLearnCode.ReevaluatingSoftwareDesignPatterns.Factory.Example1.FactoryPatternImplementation;
using Example1Simple = TaleLearnCode.ReevaluatingSoftwareDesignPatterns.Factory.Example1.SimpleObjectCreation;
using Example2Factory = TaleLearnCode.ReevaluatingSoftwareDesignPatterns.Factory.Example2.FactoryPatternImplementation;
using Example2Simple = TaleLearnCode.ReevaluatingSoftwareDesignPatterns.Factory.Example2.SimpleObjectCreation;

do
{
	PrintBanner();
	ConsoleKeyInfo userInput = Console.ReadKey(true);
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




void PrintBanner()
{
	Console.Clear();
	Console.ForegroundColor = ConsoleColor.Magenta;
	Console.WriteLine(@"___________              __                        __________         __    __                       ");
	Console.WriteLine(@"\_   _____/____    _____/  |_  ___________ ___.__. \______   \_____ _/  |__/  |_  ___________  ____  ");
	Console.WriteLine(@" |    __) \__  \ _/ ___\   __\/  _ \_  __ <   |  |  |     ___/\__  \\   __\   __\/ __ \_  __ \/    \ ");
	Console.WriteLine(@" |     \   / __ \\  \___|  | (  <_> )  | \/\___  |  |    |     / __ \|  |  |  | \  ___/|  | \/   |  \");
	Console.WriteLine(@" \___  /  (____  /\___  >__|  \____/|__|   / ____|  |____|    (____  /__|  |__|  \___  >__|  |___|  /");
	Console.WriteLine(@"     \/        \/     \/                   \/                      \/                \/           \/ ");
	Console.WriteLine();
	Console.ResetColor();
	Console.WriteLine("[1] Example 1: Factory Pattern Implementation");
	Console.WriteLine("[2] Example 1: Simple Object Creation");
	Console.WriteLine("[3] Example 2: Factory Pattern Implementation");
	Console.WriteLine("[4] Example 2: Simple Object Creation");
	Console.WriteLine();
	Console.Write("Select a demo or click [Esc] to exit");
}