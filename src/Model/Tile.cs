using System;
using System.Drawing;
using coderogue.Helpers;

namespace coderogue.Model
{
  public class Tile
  {
    public string DisplayCharacter {get; set;}
    public Point Location {get; set;}
    public int X
    {
      get {return Location.X;}
    }
    public int Y
    {
      get {return Location.Y;}
    }
    
    public Tile(int x, int y)
    {
      Location = new Point(x, y);
      DisplayCharacter = Constants.TileDisplayCharacter;
    }
  }
}
