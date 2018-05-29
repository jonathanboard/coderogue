using System;
using System.Threading;

namespace coderogue.Helpers
{
  public sealed class RandomNumberFactory
  {
    private static RandomNumberFactory instance = null;
    private static Object locker;
    private Random random;

    private RandomNumberFactory()
    {
      locker = new Object();
      random = new Random();
    }

    public static RandomNumberFactory Instance
    {
        get
        {
          if (instance == null)
          {
            instance = new RandomNumberFactory();
          }
          return instance;
        }
    }

    public int GetNext()
    {
      lock(locker)
      {
        return random.Next();
      }
    }

    public int GetNext(int min, int max)
    {
      lock(locker)
      {
        return random.Next(min, max);
      }
    }
  }
}
