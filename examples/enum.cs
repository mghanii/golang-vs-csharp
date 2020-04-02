using System;

enum LogLevel
{
  Trace = 1,
  Debug,
  Information,
  Error,
  Warning
}

[Flags]
enum Border
{
  Top,
  Right,
  Bottom,
  Left
}

class Program
{
  static void Main(string[] args)
  {
    var level = LogLevel.Information;
    Console.WriteLine(level);       // Information
    Console.WriteLine((int)level);  // 3
    Console.WriteLine((LogLevel)1); // Trace

    var border = Border.Bottom | Border.Left;

    // Checks if left border has set
    Console.WriteLine((border & Border.Left) == Border.Left); // true

    // Removes left border
    border &= ~Border.Left;
    Console.WriteLine((border & Border.Left) == Border.Left); // false

    Console.ReadKey();
  }
}