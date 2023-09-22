using System.Text;

namespace MenuSystem;
using GameBrain;
using static Console;



public class GameMenu
{
    private int[] SelectedIndex;
    private EGamePiece?[,] GameBoard;

    public GameMenu(EGamePiece?[,] board)
    {
        GameBoard = board;
        SelectedIndex = new[] {0, 0};
    }
    
    private void DisplayMenu()
    {
        var cols = GameBoard.GetLength(0);
        var rows = GameBoard.GetLength(1);
        
        WriteLine(@"Just initial checkers board.
It is not possible to play yet.
You can change selected cell using arrow keys though.");
        WriteLine();

        // column numbers 1 - n
        Write("\t  ");
        for (int i = 0; i < cols; i++)
        {
            if (i + 1 < 10)
                Write($" {i + 1} ");
            else
                Write($" {i + 1}");
        }
        Write("\n");

        for (int i = 0; i < rows; i++)
        {
            
            // row numbers 1 - n
            if (i + 1 < 10)
                Write($"\t{i + 1} ");
            else
                Write($"\t{i + 1}");
            
            for (int j = 0; j < cols; j++)
            {
                
                
                // Drawing board squares
                if (j == SelectedIndex[1] & i == SelectedIndex[0])
                {
                    BackgroundColor = ConsoleColor.Cyan;
                } else if (j % 2 == 0 & i % 2 == 0 || 
                           j % 2 == 1 & i % 2 == 1 || 
                           j == 0 & i % 2 == 0 || 
                           i == 0 & j % 2 == 0)
                {
                    BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    BackgroundColor = ConsoleColor.Gray;
                }
                
                // Drawing checker pieces and empty squares
                if (GameBoard[j, i] == EGamePiece.White)
                {
                    ForegroundColor = ConsoleColor.White;
                    OutputEncoding = Encoding.Unicode;
                    Write(" ● ");
                    OutputEncoding = Encoding.Default;
                } else if (GameBoard[j, i] == EGamePiece.Black)
                {
                    ForegroundColor = ConsoleColor.Black;
                    OutputEncoding = Encoding.Unicode;
                    Write(" ● ");
                    OutputEncoding = Encoding.Default;
                }
                else
                {
                    Write("   ");
                }
                ResetColor();
            }
            Write("\n");
        }
    }
    
    
    public int[] Run()
    {
        ConsoleKey keyPressed;
        do
        {
            Clear();
            DisplayMenu();
            
            ConsoleKeyInfo keyInfo = ReadKey(true);
            keyPressed = keyInfo.Key;
            
            
            if (keyPressed == ConsoleKey.LeftArrow & SelectedIndex[1] > 0)
            {
                SelectedIndex[1]--;
            }
            else if (keyPressed == ConsoleKey.RightArrow & SelectedIndex[1] < GameBoard.GetLength(1) - 1)
            {
                SelectedIndex[1]++;
            } else if (keyPressed == ConsoleKey.UpArrow & SelectedIndex[0] > 0)
            {
                SelectedIndex[0]--;
            } else if (keyPressed == ConsoleKey.DownArrow & SelectedIndex[0] < GameBoard.GetLength(0) - 1)
            {
                SelectedIndex[0]++;
            }
            
        } while (keyPressed != ConsoleKey.Enter);
        
        return SelectedIndex;
    }
}