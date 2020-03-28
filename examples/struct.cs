using System;

struct Point
{
  public int X { get; }
  public int Y { get; }

  public Point(int x, int y)
  {
    X = x;
    Y = y;
  }

  public override string ToString() => $"({X}, {Y})";
}

class Program
{
  static void Main(string[] args)
  {
    // Struct instantiation:

    var p = new Point(5, 7);

    Console.WriteLine(p.ToString()); // (5, 7)

    var p2 = p; // p2 is a copy of p

    Console.ReadKey();
  }
}