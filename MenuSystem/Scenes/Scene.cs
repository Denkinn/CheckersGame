namespace MenuSystem.Scenes;

public class Scene
{
    protected MenuManager MyMenuManager;
    
    public Scene(MenuManager menuManager)
    {
        MyMenuManager = menuManager;
    }

    public virtual void Run()
    {
    }
}