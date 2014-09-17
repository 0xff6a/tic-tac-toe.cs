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
}