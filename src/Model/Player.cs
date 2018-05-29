using System;
using System.Drawing;
using coderogue.Helpers;

namespace coderogue.Model
{
  public class Player : Tile
  {
    public Player(int x, int y):
    base(x, y)
    {
      DisplayCharacter = Constants.PlayerDisplayCharacter;
    }
  }
}
