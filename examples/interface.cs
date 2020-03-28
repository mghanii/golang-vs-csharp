using System;

public interface IShape
{
  double GetArea();
}

public interface IDrawable
{
  void Draw();
}

public struct Point
{
  public int X { get; }
  public int Y { get; }

  public Point(int x, int y)
  {
    X = x;
    Y = y;
  }
}

public class Square : IShape
{
  public double Side { get; set; }

  public Square(double side) => Side = side;

  public double GetArea() => Side * Side;
}

// Multiple interface implementations
public class Circle : IShape, IDrawable
{
  public Circle(Point center, double radius)
  {
    Center = center;
    Radius = radius;
  }

  public Point Center { get; set; }
  public double Radius { get; set; }

  public double GetArea() => Math.PI * Radius * Radius;

  public void Draw() => Console.WriteLine("Drawing Circle");
}

internal class Program
{
  private static void PrintArea(IShape shape)
  {
    Console.WriteLine(shape.GetArea());
  }

  private static void Main(string[] args)
  {
    var square = new Square(4);
    PrintArea(square); // 16

    var circle = new Circle(new Point(3, 6), 7);
    PrintArea(circle); // 153.93804002589985

    Console.ReadKey();
  }
}