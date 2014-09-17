using System;
using NUnit.Framework;

namespace TicTacToeComponents
{
  [TestFixture]
  //Space class tests
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

  [TestFixture]
  //Grid class tests
  public class GridTest
  {
    Grid grid;

    [SetUp]
    public void Init()
    {
      grid = new Grid();
    }

    [Test]
    public void Spaces()
    {
      Space[ , ] expected = new Space[3,3];

      Assert.AreEqual(expected, grid.Spaces);
    }

    [Test]
    public void Display()
    {
       
    }
  }
}