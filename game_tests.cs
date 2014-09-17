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
    //Space can be marked
    public void Mark()
    {
      mark = 'X';
      space.Mark(mark);

      Assert.AreEqual(mark, space.Content);
    }

    [Test]
    //Boolean IsEmpty method
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
    //Grid holds 3x3 spaces
    public void Spaces()
    {
      CollectionAssert.AllItemsAreInstancesOfType(grid.Spaces, typeof(Space));
    }

    [Test]
    //Grid can be printed to a string
    public void Display()
    {
      string expected = "X | - | - \n- | - | -\n- | - | -";
      char mark = 'X';
      Space s = new Space();
      //grid.Spaces[0,0].Mark(mark);

      Assert.AreEqual(s, 1);
      Assert.AreEqual(expected, grid.Display());
    }

  }
}