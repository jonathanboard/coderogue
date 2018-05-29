using System;
using System.Drawing;
using coderogue.Helpers;

namespace coderogue.Model
{
  public class Wall : Tile
  {
    public Wall(int x, int y):
    base(x, y)
    {
      DisplayCharacter = Constants.WallDisplayCharacter;
    }
  }
}
