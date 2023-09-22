using GameBrain;
using MenuSystem.Scenes;

namespace MenuSystem;

public class MenuManager
{
    public CheckersBrain? Game;
    public TitleScene MyTitleScene;
    public GameScene MyGameScene;
    public CreateGameScene MyCreateGameScene;
    
    public MenuManager()
    {
        MyTitleScene = new TitleScene(this);
        MyGameScene = new GameScene(this);
        MyCreateGameScene = new CreateGameScene(this);
    }

    public void Start()
    {
        MyTitleScene.Run();
    }
}