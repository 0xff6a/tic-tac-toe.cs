using TicTacToeComponents;

namespace TicTacToe
{
  public class Game
  {
    private Player challenger;
    private Player opponent;

    public Game(string challengerName, string opponentName)
    {
      challenger = new Player(challengerName, 'X');
      opponent = new Player(opponentName, 'O');
    }

    public Player Challenger
    {
      get { return challenger; }
    }

    public Player Opponent
    {
      get { return opponent; }
    }
  }
}