using System;
using NUnit.Framework;

namespace TicTacToeComponents
{
  [TestFixture]
  public class SpaceTest
  {
    Space space;
    char mark;

    [SetUp]
    public void Init()
    {
      space = new Space();
    }

    [Test]
    public void Mark()
    {
      mark = 'X';
      space.Mark(mark);

      Assert.AreEqual(mark, space.Content);
    }

    [Test]
    public void IsEmpty()
    {
      Assert.IsTrue(space.IsEmpty());
      
      space.Mark('X');
      
      Assert.IsFalse(space.IsEmpty());
    }
  }
}