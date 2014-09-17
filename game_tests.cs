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
    //Initializing the game with 2 players and a grid
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
  }
}