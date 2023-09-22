namespace MenuSystem.Scenes;
using static Console;

public class TitleScene : Scene
{
    private string TitleArt = @"
   ___  _                  _                    
  / __\| |__    ___   ___ | | __ ___  _ __  ___ 
 / /   | '_ \  / _ \ / __|| |/ // _ \| '__|/ __|
/ /___ | | | ||  __/| (__ |   <|  __/| |   \__ \
\____/ |_| |_| \___| \___||_|\_\\___||_|   |___/
                                                
";
    public TitleScene(MenuManager menuManager) : base(menuManager)
    {
    }

    public override void Run()
    {
        string prompt = $@"{TitleArt}
Welcome to Checkers. What would you like to do?
(Use arrow keys to cycle through options and press enter to select an option.)";
        string[] options = { "New Game", "About", "Exit" };
        Menu menu = new Menu(prompt, options);
        int selectedIndex = menu.Run();
        switch (selectedIndex)
        {
            case 0:
                MyMenuManager.MyCreateGameScene.Run();
                break;
            case 1:
                LoadGame();
                break;
            case 2:
                ConsoleUtils.QuitConsole();
                break;
        }
    }

    private void LoadGame()
    {
        Clear();
        WriteLine("Not implemented yet");
        ConsoleUtils.WaitForKeyPress();
        Run();
    }
}