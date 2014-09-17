using TicTacToeComponents;

namespace TicTacToe
{
  public class Game
  {
    private Player challenger;
    private Player opponent;
    private Player[] players;
    private Grid board;

    public Game(string challengerName, string opponentName)
    {
      challenger = new Player(challengerName, 'X');
      opponent = new Player(opponentName, 'O');
      players = new Player[2] { challenger, opponent };
      board = new Grid();
    }

    public Player Challenger
    {
      get { return challenger; }
    }

    public Player Opponent
    {
      get { return opponent; }
    }

    public Grid Board 
    {
      get { return board; }
    }

    public Player CurrentPlayer()
    {
      return players[0];
    }

    public void ChangeTurn()
    {
      Player tempPlayer = players[0];
      players[0] = players[1];
      players[1] = tempPlayer;
    }

    public void Go(int row, int column)
    {
      CurrentPlayer().MarkGridAt(row, column, board);
    }

    public bool HasWinner(int lastMoveRow, int lastMoveColumn)
    {
      return IsRowCompleted(lastMoveRow) || IsColumnCompleted(lastMoveColumn) ||
          IsDiagonalCompleted(lastMoveRow, lastMoveColumn);
    }

    private bool IsRowCompleted(int row)
    {
      return board.Spaces[row, 0].Content == board.Spaces[row, 1].Content && 
          board.Spaces[row, 1].Content == board.Spaces[row, 2].Content;
    }

    private bool IsColumnCompleted(int column)
    {
      return board.Spaces[0, column].Content == board.Spaces[1, column].Content && 
          board.Spaces[1, column].Content == board.Spaces[2, column].Content;
    }

    private bool IsDiagonalCompleted(int row, int column)
    {
      if(row != column && row + column != 2) { return false; }

      return IsCompleteDiagonal() || IsCompleteAntiDiagonal();
    }

    private bool IsCompleteDiagonal()
    {
      return board.Spaces[0, 0].Content == board.Spaces[1, 1].Content && 
          board.Spaces[1, 1].Content == board.Spaces[2, 2].Content;
    }

    private bool IsCompleteAntiDiagonal()
    {
      return board.Spaces[0, 2].Content == board.Spaces[1, 1].Content && 
          board.Spaces[1, 1].Content == board.Spaces[2, 0].Content;
    }
  }
}