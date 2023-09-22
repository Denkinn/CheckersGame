using GameBrain;

namespace MenuSystem.Scenes;
using static Console;

public class CreateGameScene : Scene
{
    public CreateGameScene(MenuManager menuManager) : base(menuManager)
    {
    }

    public override void Run()
    {
        int boardWidth = 8;
        int boardHeight = 8;
        
        string prompt = @"Game creation page
Please select size of board you would like to create.";
        string[] options = {"8x8", "10x10", "12x12"};
        Menu menu = new Menu(prompt, options);
        int selectedIndex = menu.Run();
        switch (selectedIndex)
        {
            case 0:
                boardWidth = 8;
                boardHeight = 8;
                break;
            case 1:
                boardWidth = 10;
                boardHeight = 10;
                break;
            case 2:
                boardWidth = 12;
                boardHeight = 12;
                break;
        }
        
        
        WriteLine($"Creating board with parameters: width {boardWidth} x height {boardHeight}");
        ConsoleUtils.WaitForKeyPress();
        MyMenuManager.Game = new CheckersBrain(boardWidth, boardHeight);
        MyMenuManager.MyGameScene.Run();
    }
}