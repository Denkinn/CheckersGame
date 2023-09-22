// See https://aka.ms/new-console-template for more information

using MenuSystem;
using static System.Console;

Title = "The Game";
CursorVisible = false;

MenuManager myGame = new MenuManager();
myGame.Start();