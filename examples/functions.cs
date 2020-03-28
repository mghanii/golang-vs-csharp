using System;

internal class Program
{
  // Overloaded methods
  public static int Sum(int a, int b) => a + b;

  public static int Sum(int a, int b, int c) => a + b + c;

  // Method with a parameter that takes a variable number of arguments
  public static int Multiply(params int[] values)
  {
    var result = 1;

    for (var i = 0; i < values.Length; i++)
    {
      result *= values[i];
    }

    return result;
  }

  // Method with multiple return values
  public static Tuple<string, int, bool> GetValues()
  {
    return Tuple.Create("some value", 1, false);
  }

  // Func is a delegate type which holds a reference to a method
  public static int Transform(Func<int, int> transformer, int value)
  {
    return transformer(value);
  }

  // Optional parameters
  public static int Increment(int value, int step = 1)
  {
    return value + step;
  }

  public static int Square(int value) => value * value;

  private static void Main(string[] args)
  {
    var square = Transform(Square, 3);
    Console.WriteLine(square);       // 9

    // Anonymous method
    square = Transform(delegate (int value) { return value * value; }, 3);
    Console.WriteLine(square);       // 9

    Console.WriteLine(Sum(1, 2));    // 3
    Console.WriteLine(Sum(1, 2, 3)); // 6

    Console.WriteLine(Increment(1));    // 2
    Console.WriteLine(Increment(1, 5)); // 6

    Console.WriteLine(Multiply(1, 2));       // 2
    Console.WriteLine(Multiply(1, 2, 3));    // 6
    Console.WriteLine(Multiply(1, 2, 3, 4)); // 24

    Console.ReadKey();
  }
}