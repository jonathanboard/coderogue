using System;
using System.Collections.Generic;
using coderogue.Model;
using coderogue.Helpers;

namespace coderogue
{
  public class Dungeon
  {
    public string Name {get;set;}
    public Tile[,] Tiles {get; set;}
    public bool IsActive = true;

    public Dungeon()
    {
       Tiles = new Tile[Constants.xMax, Constants.yMax];

       for (int i = 0; i < Constants.yMax; i++)
       {
         for (int j = 0; j < Constants.xMax; j++)
         {
           Tiles[j,i] = new Tile(i,j);
         }
       }
    }

    public void ProcessCommand()
    {
      var input = Console.ReadLine();

      switch(input)
      {
        case "q":
          IsActive = false;
          break;
        default:
          Console.Write(input);
          break;
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
