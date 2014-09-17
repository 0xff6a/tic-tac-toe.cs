using TicTacToeComponents;

namespace TicTacToe
{
  public class Game
  {
    private Player challenger;
    private Player opponent;
    private Player[] players;
    private Player winner;
    private Grid board;
    public const int maxMoves = Grid.size * Grid.size;

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
    
    public Player Winner
    {
      get { return winner; }
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
      
      if(HasWinner(row, column))
      {
        winner = CurrentPlayer();
      }
      
      ChangeTurn();
    }

    public bool HasWinner(int lastMoveRow, int lastMoveColumn)
    {
      return IsRowCompleted(lastMoveRow) || IsColumnCompleted(lastMoveColumn) ||
          IsDiagonalCompleted(lastMoveRow, lastMoveColumn);
    }

    public bool IsDraw()
    {
      return moveCount() == maxMoves && winner == null;
    }

    public bool IsUndecided()
    {
      return Winner == null && !IsDraw();
    }

    private int moveCount()
    {
      int count = 0;
      foreach(Space s in board.Spaces)
      {
        if(s.Content != '-') { count++; }
      }
      return count;
    }

    private bool IsRowCompleted(int row)
    {
      return IsMarkedRow(row) && IsUniformRow(row);
    }

    private bool IsColumnCompleted(int column)
    {
      return IsMarkedColumn(column) && IsUniformColumn(column);
    }

    private bool IsDiagonalCompleted(int row, int column)
    {
      if(IsNotOnDiagonal(row, column)) { return false; }

      return IsCentreMarked() && (IsUniformDiagonal() || IsUniformAntiDiagonal());
    }

    private bool IsNotOnDiagonal(int row, int column)
    {
      return row != column && row + column != 2;
    }

    private bool IsUniformDiagonal()
    {
      return board.Spaces[0, 0].Content == board.Spaces[1, 1].Content && 
          board.Spaces[1, 1].Content == board.Spaces[2, 2].Content;
    }

    private bool IsUniformAntiDiagonal()
    {
      return board.Spaces[0, 2].Content == board.Spaces[1, 1].Content && 
          board.Spaces[1, 1].Content == board.Spaces[2, 0].Content;
    }

    private bool IsCentreMarked()
    {
      return !board.Spaces[1,1].IsEmpty();
    }

    private bool IsMarkedColumn(int column)
    {
      return !board.Spaces[0,column].IsEmpty();
    }

    private bool IsMarkedRow(int row)
    {
      return !board.Spaces[row,0].IsEmpty();
    }

    private bool IsUniformRow(int row)
    {
      return board.Spaces[row, 0].Content == board.Spaces[row, 1].Content && 
          board.Spaces[row, 1].Content == board.Spaces[row, 2].Content;
    }

    private bool IsUniformColumn(int column)
    {
      return board.Spaces[0, column].Content == board.Spaces[1, column].Content && 
          board.Spaces[1, column].Content == board.Spaces[2, column].Content;
    }
  }
}