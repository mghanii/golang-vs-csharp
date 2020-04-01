using System;
using System.Threading;

/// <summary>
/// Thread safe Id generator
/// </summary>
internal class IdGenerator
{
  private static int _lastId;

  // returns a new id with a unique value
  public static int GetNextId()
  {
    return Interlocked.Increment(ref _lastId);
  }
}

internal class Program
{
  private static void Main(string[] args)
  {
    int i = 4;

    // Interlocked.Increment(ref i);
    // Interlocked.Decrement(ref i);
    // Interlocked.Exchange(ref i, 0);

    Console.ReadKey();
  }
}