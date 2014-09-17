using System;
using TicTacToe;
using TicTacToeComponents;

namespace TicTacToeApplication
{
  public class TicTacToeRunner
  {
    public static void Main()
    {
      string pName, oName;
      Game game;

      Console.WriteLine("Welcome to Tic Tac Toe");
      Console.WriteLine("Please enter your name:");
      pName = Console.ReadLine();
      Console.WriteLine("Who dares challenge you?");
      oName = Console.ReadLine();

      game = new Game(pName, oName);

      while(game.IsUndecided())
      {
        Console.WriteLine(game.Board.Display());
        Console.WriteLine("Enter your move e.g row-column");
        
        string[] move = Console.ReadLine().Split('-');
        game.Go(int.Parse(move[0]), int.Parse(move[1]));
      }

      if( game.Winner != null )
      {
        Console.WriteLine("Congratulations! {0} Wins", game.Winner.Name);
      }
      else 
      {
        Console.WriteLine("Draw!");
      }

    }
  }
}