using NUnit.Framework;
using TicTacToeComponents;

namespace TicTacToe
{
  [TestFixture]
  //Game class tests
  public class GameTest
  {
    Game game;

    [SetUp]
    public void Init()
    {
      game = new Game("Me", "EvilMe");
    }

    [Test]
    //Initializing the game with 2 players and a board
    public void Start()
    {
      Assert.AreEqual("Me", game.Challenger.Name);
      Assert.AreEqual("EvilMe", game.Opponent.Name);
      Assert.AreEqual(typeof(Grid), game.Board.GetType());
    }

    [Test]
    //The current player
    public void CurrentPlayer()
    {
      Assert.AreEqual(game.Challenger, game.CurrentPlayer());
    }

    [Test]
    //changing turns
    public void ChangeTurn()
    {
      game.ChangeTurn();

      Assert.AreEqual(game.Opponent, game.CurrentPlayer());
    }

    [Test]
    //making a move
    public void GameConclusion()
    {
      game.Go(0,0);

      Assert.AreEqual('X', game.Board.Spaces[0,0].Content);
    }

    [Test]
    //Checking for a winner
    public void IsWinner()
    {
      _setupChallengerWin();

      Assert.IsTrue(game.IsWinner());
    }

    [Test]
    //Checking for a draw
    public void IsDraw()
    {
      
    }

    [Test]
    //Returning the winner
    public void Winner()
    {

    }

    public void _setupChallengerWin()
    {
      game.Go(0,0);
      game.Go(1,0);
      game.Go(0,1);
      game.Go(1,1);
      game.Go(0,2);
    }

  }
}