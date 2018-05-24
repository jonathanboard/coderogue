using System;

namespace coderogue
{
    class Program
    {
        static void Main(string[] args)
        {
          var dungeon = new Dungeon();
          dungeon.Name = "thing is a thing";
          Console.Clear();
          while(dungeon.IsActive)
          {
            dungeon.Display();
            dungeon.ProcessCommand();
          }
            //Console.WriteLine(dungeon.Name);
        }
    }
}
