using System;

class Program
{
  static void Main(string[] args)
  {
    var color = "blue";

    switch (color)
    {
      case "red":
        Console.WriteLine("Red code is #FF0000");
        break;

      case "blue":
        Console.WriteLine("Blue code is #0000FF");
        break;

      default:
        Console.WriteLine("Invalid color");
        break;
    }

    var a = 2;

    switch (a)
    {
      case 1:
      case 2:
      case 3:
        Console.WriteLine("case 1, 2 or 3");
        break;

      case 4:
        Console.WriteLine("case 4");
        break;

      default:
        Console.WriteLine("default case");
        break;
    }

    // Checking for type (C# 7)

    object obj = 4;

    switch (obj)
    {
      case null:
        Console.WriteLine("obj is null");
        break;

      case int v:
        Console.WriteLine("obj is int");
        break;

      case string v:
        Console.WriteLine("obj is string");
        break;

      default:
        Console.WriteLine("obj type is not know");
        break;
    }

    Console.ReadKey();
  }
}