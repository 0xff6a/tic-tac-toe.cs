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
    //Setting up the game
    public void Start()
    {
      Assert.AreEqual("Me", game.Challenger.Name);
      Assert.AreEqual("EvilMe", game.Opponent.Name);
    }
  }
}