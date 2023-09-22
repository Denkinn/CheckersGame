namespace MenuSystem;

using static Console;

public class Menu
{
    private int SelectedIndex;
    private string[] Options;
    private string Prompt;

    public Menu(string prompt, string[] options)
    {
        Prompt = prompt;
        Options = options;
        SelectedIndex = 0;
    }

    private void DisplayMenu()
    {
        WriteLine(Prompt);
        for (int i = 0; i < Options.Length; i++)
        {
            string currentOption = Options[i];
            string prefix;
            if (i == SelectedIndex)
            {
                prefix = ">>";
                ForegroundColor = ConsoleColor.Black;
                BackgroundColor = ConsoleColor.White;
            }
            else
            {
                prefix = "  ";
                ForegroundColor = ConsoleColor.White;
                BackgroundColor = ConsoleColor.Black;
            }
            
            WriteLine($"{prefix} {currentOption}");
        }
        ResetColor();
    }

    public int Run()
    {
        ConsoleKey keyPressed;
        do
        {
            Clear();
            DisplayMenu();
            
            ConsoleKeyInfo keyInfo = ReadKey(true);
            keyPressed = keyInfo.Key;

            if (keyPressed == ConsoleKey.UpArrow & SelectedIndex > 0)
            {
                SelectedIndex--;
            }
            else if (keyPressed == ConsoleKey.DownArrow & SelectedIndex < Options.Length - 1)
            {
                SelectedIndex++;
            }
        } while (keyPressed != ConsoleKey.Enter);
        
        return SelectedIndex;
    }
}