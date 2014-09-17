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
  }
}