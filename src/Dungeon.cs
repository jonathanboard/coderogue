using System;
using System.Collections.Generic;
using coderogue.Model;
using coderogue.Helpers;
using System.Drawing;

namespace coderogue
{
  public class Dungeon
  {
    public string Name {get;set;}
    public Tile[,] Tiles {get; set;}
    public bool IsActive = true;
    public Player player;

    public Dungeon()
    {
       Tiles = new Tile[Constants.xMax, Constants.yMax];
       InitTiles();
       InitWalls();
       InitPlayer();
    }


    private void InitTiles()
    {
      for (int i = 0; i < Constants.yMax; i++)
      {
        for (int j = 0; j < Constants.xMax; j++)
        {
          Tiles[j,i] = new Tile(i,j);
        }
      }
    }

    private void InitPlayer()
    {
      player = new Player(RandomNumberFactory.Instance.GetNext(0, Constants.xMax), RandomNumberFactory.Instance.GetNext(0, Constants.yMax));
      Tiles[player.X,player.Y] = player;
    }

    private void InitWalls()
    {
      for (int i = 0; i < Constants.yMax; i++)
      {
        for (int j = 0; j < Constants.xMax; j++)
        {
          if(i == 0 || j == 0 || i == Constants.yMax -1 || j == Constants.xMax - 1)
          {
            Tiles[j,i] = new Wall(i,j);
          }
        }
      }
    }

    private bool IsValidMove(Point point)
    {
      if(point.X <= 0 || point.Y <=0 || point.X > Constants.xMax - 1 || point.Y > Constants.yMax - 1)
      {
        return false;
      }

      return true;
    }

    public void ProcessCommand()
    {
      var input = Console.ReadKey(true);
      Point point;

      switch(input.Key)
      {
        case ConsoleKey.UpArrow:
          point = new Point(player.X, player.Y + 1);
        break;
        case ConsoleKey.DownArrow:
          point = new Point(player.X, player.Y - 1);
        break;
        case ConsoleKey.LeftArrow:
          point = new Point(player.X - 1, player.Y);
        break;
        case ConsoleKey.RightArrow:
          point = new Point(player.X + 1, player.Y);
        break;
        default:
          point = new Point(player.X, player.Y);
          //Console.Write(input);
          break;
      }

      if(IsValidMove(point))
      {
        Tiles[player.X, player.Y] = new Tile(player.X, player.Y);
        player.Location = point;
        Tiles[player.X, player.Y] = player;
      }
    }



    public void Display()
    {
      Console.Clear();
      for (int i = 0; i < Constants.yMax; i++)
      {
        for (int j = 0; j < Constants.xMax; j++)
        {
          Console.Write(Tiles[j,i].DisplayCharacter);
        }
        Console.Write("\n");
      }
    }
  }
}
