namespace TaleLearnCode.ReevaluatingSoftwareDesignPatterns.Factory;

internal static class PrintBanner
{

	internal static void Program()
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

	internal static void Example1Factory()
	{
		Console.WriteLine();
		Console.WriteLine();
		Console.ForegroundColor = ConsoleColor.DarkRed;
		Console.WriteLine(@"___________                             .__            ____      ___________              __                       ");
		Console.WriteLine(@"\_   _____/__  ________    _____ ______ |  |   ____   /_   | /\  \_   _____/____    _____/  |_  ___________ ___.__.");
		Console.WriteLine(@" |    __)_\  \/  /\__  \  /     \\____ \|  | _/ __ \   |   | \/   |    __) \__  \ _/ ___\   __\/  _ \_  __ <   |  |");
		Console.WriteLine(@" |        \>    <  / __ \|  Y Y  \  |_> >  |_\  ___/   |   | /\   |     \   / __ \\  \___|  | (  <_> )  | \/\___  |");
		Console.WriteLine(@"/_______  /__/\_ \(____  /__|_|  /   __/|____/\___  >  |___| \/   \___  /  (____  /\___  >__|  \____/|__|   / ____|");
		Console.WriteLine(@"        \/      \/     \/      \/|__|             \/                  \/        \/     \/                   \/     ");
		Console.ResetColor();
		Console.WriteLine();
		Console.WriteLine();
	}

	internal static void Example1Simple()
	{
		Console.WriteLine();
		Console.WriteLine();
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine(@"___________                             .__            ____        _________.__               .__          ");
		Console.WriteLine(@"\_   _____/__  ________    _____ ______ |  |   ____   /_   | /\   /   _____/|__| _____ ______ |  |   ____  ");
		Console.WriteLine(@" |    __)_\  \/  /\__  \  /     \\____ \|  | _/ __ \   |   | \/   \_____  \ |  |/     \\____ \|  | _/ __ \ ");
		Console.WriteLine(@" |        \>    <  / __ \|  Y Y  \  |_> >  |_\  ___/   |   | /\   /        \|  |  Y Y  \  |_> >  |_\  ___/ ");
		Console.WriteLine(@"/_______  /__/\_ \(____  /__|_|  /   __/|____/\___  >  |___| \/  /_______  /|__|__|_|  /   __/|____/\___  >");
		Console.WriteLine(@"        \/      \/     \/      \/|__|             \/                     \/          \/|__|             \/ ");
		Console.ResetColor();
		Console.WriteLine();
		Console.WriteLine();
	}

	internal static void Example2Simple()
	{
		Console.WriteLine();
		Console.WriteLine();
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine(@"___________                             .__           ________         _________.__               .__          ");
		Console.WriteLine(@"\_   _____/__  ________    _____ ______ |  |   ____   \_____  \  /\   /   _____/|__| _____ ______ |  |   ____  ");
		Console.WriteLine(@" |    __)_\  \/  /\__  \  /     \\____ \|  | _/ __ \   /  ____/  \/   \_____  \ |  |/     \\____ \|  | _/ __ \ ");
		Console.WriteLine(@" |        \>    <  / __ \|  Y Y  \  |_> >  |_\  ___/  /       \  /\   /        \|  |  Y Y  \  |_> >  |_\  ___/ ");
		Console.WriteLine(@"/_______  /__/\_ \(____  /__|_|  /   __/|____/\___  > \_______ \ \/  /_______  /|__|__|_|  /   __/|____/\___  >");
		Console.WriteLine(@"        \/      \/     \/      \/|__|             \/          \/             \/          \/|__|             \/ ");
		Console.ResetColor();
		Console.WriteLine();
		Console.WriteLine();
	}

	internal static void Example2Factory()
	{
		Console.WriteLine();
		Console.WriteLine();
		Console.ForegroundColor = ConsoleColor.DarkRed;
		Console.WriteLine(@"___________                             .__           ________       ___________              __                       ");
		Console.WriteLine(@"\_   _____/__  ________    _____ ______ |  |   ____   \_____  \  /\  \_   _____/____    _____/  |_  ___________ ___.__.");
		Console.WriteLine(@" |    __)_\  \/  /\__  \  /     \\____ \|  | _/ __ \   /  ____/  \/   |    __) \__  \ _/ ___\   __\/  _ \_  __ <   |  |");
		Console.WriteLine(@" |        \>    <  / __ \|  Y Y  \  |_> >  |_\  ___/  /       \  /\   |     \   / __ \\  \___|  | (  <_> )  | \/\___  |");
		Console.WriteLine(@"/_______  /__/\_ \(____  /__|_|  /   __/|____/\___  > \_______ \ \/   \___  /  (____  /\___  >__|  \____/|__|   / ____|");
		Console.WriteLine(@"        \/      \/     \/      \/|__|             \/          \/          \/        \/     \/                   \/     ");
		Console.ResetColor();
		Console.WriteLine();
		Console.WriteLine();
	}
}