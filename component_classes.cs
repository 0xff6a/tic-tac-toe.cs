using System;

namespace TicTacToeComponents
{
  public class Space
  {
    private char content = '-';

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
      return content == '-';
    }
  }

  public class Grid
  {
    private static int size = 3;
    private Space[ , ] spaces = new Space[size, size];

    public Grid()
    {
      for( int i = 0; i < size; i++) 
      {
        for( int j = 0; j < size; j++)
        {
          spaces[i,j] = new Space(); 
        }
      }
    }
    
    public Space[ , ] Spaces
    {
      get { return spaces; }
    }

    public string Display()
    {
      string result = "";
      
      for( int i = 0; i < size; i++) 
      {
        for( int j = 0; j < size; j++)
        {
          result += spaces[i,j].Content; 
          if( j != 2) { result += " | "; }
        }
        result += '\n';
      }

      return result;
    }
  }

  public class Player 
  {
    private string name;
    private char mark;

    public Player(string nm, char mk)
    {
      name = nm;
      mark = mk;
    }

    public string Name 
    {
      get { return name; }
    }

    public char XorO
    {
      get { return mark; }
    }

    public void MarkGridAt(int row, int column, Grid grid)
    {
      grid.Spaces[row, column].Mark(mark);
    }
  }
}