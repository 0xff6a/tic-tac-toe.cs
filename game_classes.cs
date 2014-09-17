using System;

namespace TicTacToeComponents
{
  public class Space
  {
    private char content;

    public void Mark(char playerMark)
    {
      content = playerMark;
    }

    public char Content 
    {
      get { return content; }
    }

    public bool IsEmpty()
    {
      return content == default(char);
    }
  }

  public class Grid
  {
    private static int size = 3;
    private Space[ , ] spaces = new Space[size, size];

    public Space[ , ] Spaces
    {
      get { return spaces; }
    }


  }
}