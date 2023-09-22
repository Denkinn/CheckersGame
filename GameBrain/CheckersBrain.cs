namespace GameBrain;

public class CheckersBrain
{
    private readonly EGamePiece?[,] _gameBoard;
    
    public CheckersBrain(int boardWidth = 8, int boardHeight = 8)
    {
        _gameBoard = new EGamePiece?[boardWidth, boardHeight];

        for (int i = 0; i < boardHeight; i++)
        {
            for (int j = 0; j < boardWidth; j++)
            {
                // filter to keep only black squares
                if (j % 2 == 0 & i % 2 == 1 ||
                    j % 2 == 1 & i % 2 == 0 ||
                    j == 0 & i % 2 == 1 ||
                    i == 0 & j % 2 == 1)
                {
                    if (i < 3) // first three rows black pieces
                        _gameBoard[j, i] = EGamePiece.Black;
                    else if (i > boardHeight - 4) // last three rows white pieces
                        _gameBoard[j, i] = EGamePiece.White;
                }
            }
        }
    }

    // get copy of the board
    public EGamePiece?[,] GetBoard()
    {
        var res = new EGamePiece?[_gameBoard.GetLength(0), _gameBoard.GetLength(1)];
        Array.Copy(_gameBoard, res, _gameBoard.Length);
        return res;
    }
}