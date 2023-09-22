namespace MenuSystem;
using static Console;

public static class ConsoleUtils
{
    public static void WaitForKeyPress()
    {
        WriteLine("(Press any key to continue.)");
        ReadKey(true);
    }

    public static void QuitConsole()
    {
        WriteLine("(Press any key to exit.)");
        ReadKey(true);
        Environment.Exit(0);
    }
}