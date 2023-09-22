using GameBrain;

namespace MenuSystem.Scenes;

public class GameScene : Scene
{
    
    public GameScene(MenuManager menuManager) : base(menuManager)
    {
    }

    public override void Run()
    {
        GameMenu myGameMenu = new GameMenu(MyMenuManager.Game!.GetBoard());
        int[] selectedIndex = myGameMenu.Run();
        ConsoleUtils.WaitForKeyPress();
    }
}